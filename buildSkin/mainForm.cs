using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using NCalc;

namespace buildSkin
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        void mainFormLoad(object o, EventArgs e)
        {
            skinRefreshList();
            skinFillTable();

            settingLoad(new object(), new LinkLabelLinkClickedEventArgs(new LinkLabel.Link()));

            //Apply
            updateOpacity(new Control(), new EventArgs());
            if (settingsAutoLoad.Checked && lastSkin != string.Empty && skinsList.Items.Contains(lastSkin))
            {
                skinsList.SelectedIndex = skinsList.Items.IndexOf(lastSkin); //Also loads it
            }

            if (firstRun)
            {
                MessageBox.Show("Thank you for downloading BuildSkin.\n\nYou should first go to the settings tab and " +
                "set your resolution and other preferred options.\n\nThen go to the addons tab and download what you find " +
                "interesting. (A description is in the status bar.)\n\nTo make a skin, go to the skins tab, select the " +
                "desired options from the right column, give it a name in the upper-left box, and click 'Build.'\n\nIf " +
                "anything confuses you, please refer to the resources in the information tab section.", "Welcome to BuildSkin!");
                firstRun = false;
            }
        }
        void mainFormClose(object o, FormClosingEventArgs e)
        {
            settingSave(new object(), new LinkLabelLinkClickedEventArgs(new LinkLabel.Link()));
        }

        void skinBuild(object o, LinkLabelLinkClickedEventArgs e)
        {
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }
            if (!System.IO.Directory.Exists(".\\Skins\\" + skinsList.Text) || !settingsConfirmation.Checked || MessageBox.Show("Do you want to overwrite the previous skin?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                List<string> configLines = new List<string>();
                XmlReaderSettings xrs = new XmlReaderSettings();
                xrs.ConformanceLevel = ConformanceLevel.Fragment;
                skinXML.RemoveAll();
                skinXML.LoadXml("<?xml version=\"1.0\"?><opt><SkinName Name=\"" + skinsList.Text + "\" /></opt>");

                statusProgress.Minimum = 0;
                statusProgress.Value = 0;
                statusProgress.Maximum = skinsCustomize.RowCount;
                foreach (DataGridViewRow row in skinsCustomize.Rows)
                {
                    statusProgress.Increment(1);
                    if (row.Cells["customOptions"].Value.ToString() != "--")
                    {
                        configLines.Add(row.Cells["customCategory"].Value.ToString() + ">" + row.Cells["customName"].Value.ToString() + "=" + row.Cells["customOptions"].Value.ToString());
                        XmlReader reader = XmlReader.Create(".\\Elements\\" + row.Cells["customCategory"].Value.ToString() + "\\" + row.Cells["customName"].Value.ToString() + "\\" + row.Cells["customOptions"].Value.ToString() + ".xml", xrs);
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                skinXML.DocumentElement.AppendChild(skinXML.ReadNode(reader.ReadSubtree()));
                            }
                        }
                    }
                }

                XmlNodeList nodes = skinXML.SelectNodes("//Element/@*");
                statusProgress.Maximum = nodes.Count;
                statusProgress.Value = 0;
                foreach (XmlAttribute node in nodes)
                {
                    statusProgress.Increment(1);
                    if (node.Name != "ID" && node.Value.Contains("{"))
                    {
                        node.Value = resolveVars(node.Value);
                    }
                }

                System.IO.Directory.CreateDirectory(".\\Skins\\" + skinsList.Text);
                System.IO.File.WriteAllLines(".\\Skins\\" + skinsList.Text + "\\BuildSkin", configLines.ToArray());
                skinXML.Save(".\\Skins\\" + skinsList.Text + "\\SkinDefinition.xml");
                skinRefreshList();
                statusText.Text = "Skin " + skinsList.Text + " built successfully!";
            }
        }
        string resolveVars(string expr)
        {
            expr = expr.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)[0];
            string[] vars = expr.Split(new char[] { ',', '+', '-', '*', '/', '(', ')', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string var in vars)
            {
                if (var.Split('.')[0].ToLowerInvariant() == "screen") //Most specific case
                {
                    if (var.Split('.')[1].ToLowerInvariant().StartsWith("w"))
                    {
                        expr = expr.Replace(var, settingsResolution.Text.Split('x')[0]);
                    }
                    else if (var.Split('.')[1].ToLowerInvariant().StartsWith("h"))
                    {
                        expr = expr.Replace(var, settingsResolution.Text.Split('x')[1]);
                    }
                    else
                    {
                        expr = expr.Replace(var, "0"); //Unknown screen property
                    }
                }
                else if (skinXML.SelectSingleNode("//Element[@ID='" + var.Split('.')[0] + "']") != null)
                {
                    foreach (XmlAttribute attr in skinXML.SelectSingleNode("//Element[@ID='" + var.Split('.')[0] + "']").Attributes)
                    {
                        if (attr.Name.StartsWith(var.Split('.')[1].Substring(0, 1)))
                        {
                            attr.Value = resolveVars(attr.Value);
                            expr = expr.Replace(var, attr.Value);
                        }
                    }
                }
            }
            return new Expression("Round(" + expr + ",0)").Evaluate().ToString();
        }
        void skinRename(object o, LinkLabelLinkClickedEventArgs e)
        {
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }
            //Prompt Dialog
            MessageBox.Show("My tech is too low.", "Not Implemented");

            skinRefreshList();
        }
        void skinDelete(object o, LinkLabelLinkClickedEventArgs e)
        {
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }
            if (!settingsConfirmation.Checked || MessageBox.Show("Are you sure you want to delete the skin '" + skinsList.SelectedItem + "'", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (settingsNoRecycle.Checked)
                {
                    if (System.IO.Directory.Exists(".\\Skins\\" + skinsList.SelectedItem))
                    {
                        System.IO.Directory.Delete(".\\Skins\\" + skinsList.SelectedItem, true);
                    }
                    statusText.Text = "Skin " + skinsList.SelectedItem + " successfully deleted!";
                }
                else
                {
                    MessageBox.Show("I haven't teched up to recycling centers yet, so you'll have to either delete directly or delete manually outside the program.", "Blatant Civ Reference");
                }
                skinRefreshList();
            }
        }
        void skinEditXML(object o, LinkLabelLinkClickedEventArgs e)
        {
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }
            if (System.IO.File.Exists(".\\Skins\\" + skinsList.SelectedItem + "\\SkinDefinition.xml") && System.IO.File.Exists(settingsEditorPath.Text))
            {
                System.Diagnostics.Process procEditor = new System.Diagnostics.Process();
                procEditor.StartInfo = new System.Diagnostics.ProcessStartInfo(settingsEditorPath.Text, "\"Skins\\" + skinsList.SelectedItem + "\\SkinDefinition.xml\"");
                procEditor.Start();
            }
        }
        void skinReload(object o, LinkLabelLinkClickedEventArgs e)
        {
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }
            skinClear(new object(), new LinkLabelLinkClickedEventArgs(new LinkLabel.Link()));
            if (System.IO.File.Exists(".\\Skins\\" + skinsList.SelectedItem + "\\BuildSkin"))
            {
                foreach (string line in System.IO.File.ReadAllLines(".\\Skins\\" + skinsList.SelectedItem + "\\BuildSkin"))
                {
                    foreach (DataGridViewRow row in skinsCustomize.Rows)
                    {
                        if (row.Cells["customCategory"].Value.ToString() + ">" + row.Cells["customName"].Value.ToString() == line.Split('=')[0])
                        {
                            if (((DataGridViewComboBoxCell)row.Cells["customOptions"]).Items.Contains(line.Split('=')[1]))
                            {
                                row.Cells["customOptions"].Value = line.Split('=')[1];
                            }
                        }
                    }
                }
            }
        }
        void skinClear(object o, LinkLabelLinkClickedEventArgs e)
        {
            foreach (DataGridViewRow row in skinsCustomize.Rows)
            {
                row.Cells["customOptions"].Value = "--";
            }
        }
        void skinSelect(object o, EventArgs e)
        {
            if (skinsList.SelectedIndex != -1)
            {
                skinReload(new object(), new LinkLabelLinkClickedEventArgs(new LinkLabel.Link()));
            }
        }
        void skinRefreshList()
        {
            string current = skinsList.Text;
            skinsList.Items.Clear();
            foreach (string skin in System.IO.Directory.GetDirectories(".\\Skins"))
            {
                skinsList.Items.Add(skin.Remove(0, 8));
            }
            if (skinsList.Items.Contains(current))
            {
                skinsList.SelectedItem = current;
            }
        }
        void skinFillTable()
        {
            skinsCustomize.Rows.Clear();
            foreach (string category in System.IO.Directory.GetDirectories(".\\Elements"))
            {
                foreach (string element in System.IO.Directory.GetDirectories(category))
                {
                    skinsCustomize.Rows.Add(category.Replace(".\\Elements\\", string.Empty), element.Replace(category + "\\", string.Empty));
                    foreach (string option in System.IO.Directory.GetFiles(element, "*.xml"))
                    {
                        ((DataGridViewComboBoxCell)skinsCustomize.Rows[skinsCustomize.RowCount - 1].Cells["customOptions"]).Items.Add(option.Replace(element + "\\", string.Empty).Replace(".xml", string.Empty));
                    }
                    ((DataGridViewComboBoxCell)skinsCustomize.Rows[skinsCustomize.RowCount - 1].Cells["customOptions"]).Items.Add("--");
                    ((DataGridViewComboBoxCell)skinsCustomize.Rows[skinsCustomize.RowCount - 1].Cells["customOptions"]).Value = "--";
                }
            }
        }

        void addonFilter(object o, EventArgs e)
        {
            foreach (DataGridViewRow row in addonsDataGrid.Rows)
            {
                if (row.Cells["addonsName"].Value.ToString().ToLowerInvariant().Contains(addonsFilter.Text.ToLowerInvariant()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
        void addonRefreshRemote(object o, LinkLabelLinkClickedEventArgs e)
        {

            var list = new AutoCompleteStringCollection();
            foreach (DataGridViewRow row in addonsDataGrid.Rows)
            {
                list.Add(row.Cells["addonsName"].Value.ToString());
            }
            addonsFilter.AutoCompleteCustomSource = list;
        }
        void addonRefreshLocal(object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void addonDelete(object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void addonInstUpd(object o, LinkLabelLinkClickedEventArgs e)
        {


            //clear selection (runs handler)
            addonsSelectAll.CheckState = CheckState.Unchecked;
        }
        void addonSelectAll(object o, EventArgs e)
        {
            if (addonsSelectAll.CheckState == CheckState.Checked)
            {
                foreach (DataGridViewRow row in addonsDataGrid.Rows)
                {
                    if (row.Cells["addonsVersion"].Value.ToString().ToLowerInvariant() != row.Cells["addonsInstVer"].Value.ToString().ToLowerInvariant())
                    {
                        ((DataGridViewCheckBoxCell)row.Cells["addonSelected"]).Value = true;
                    }
                    else
                    {
                        ((DataGridViewCheckBoxCell)row.Cells["addonSelected"]).Value = false;
                    }
                }
            }
            else if (addonsSelectAll.CheckState == CheckState.Unchecked)
            {
                foreach (DataGridViewRow row in addonsDataGrid.Rows)
                {
                    ((DataGridViewCheckBoxCell)row.Cells["addonSelected"]).Value = false;
                }
            }
        }

        void settingLoad(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Load From File
            if (System.IO.File.Exists(".\\BuildSkin.conf"))
            {
                string[] configLines = System.IO.File.ReadAllLines(".\\BuildSkin.conf");
                settingsTranslucent.Checked = (configLines[0].ToLowerInvariant() == "true");
                settingsTransMax.Checked = (configLines[1].ToLowerInvariant() == "true");
                settingsAutoLoad.Checked = (configLines[2].ToLowerInvariant() == "true");
                settingsConfirmation.Checked = (configLines[3].ToLowerInvariant() == "true");
                settingsNoRecycle.Checked = (configLines[4].ToLowerInvariant() == "true");
                settingsReadOnly.Checked = (configLines[5].ToLowerInvariant() == "true");
                settingsEditorPath.Text = configLines[6];
                settingsResolution.Items.Clear();
                settingsResolution.Items.AddRange(configLines[7].Split(','));
                settingsResolution.SelectedIndex = settingsResolution.Items.IndexOf(configLines[8]);
                lastSkin = configLines[9];
                firstRun = (configLines[10].ToLowerInvariant() == "true");
            }
        }
        void settingSave(object o, LinkLabelLinkClickedEventArgs e)
        {
            string[] resolutions = new string[settingsResolution.Items.Count];
            settingsResolution.Items.CopyTo(resolutions, 0);
            System.IO.File.WriteAllLines(".\\BuildSkin.conf", new string[] {
                settingsTranslucent.Checked.ToString(),
                settingsTransMax.Checked.ToString(),
                settingsAutoLoad.Checked.ToString(),
                settingsConfirmation.Checked.ToString(),
                settingsNoRecycle.Checked.ToString(),
                settingsReadOnly.Checked.ToString(),
                settingsEditorPath.Text,
                string.Join(",", resolutions),
                settingsResolution.SelectedItem.ToString(),
                skinsList.Text,
                firstRun.ToString()
            });
        }
        void updateOpacity(object o, EventArgs e)
        {
            //Checking "Even when maximized" enables basic translucency
            if (((Control)o).Name == "settingsTransMax" && ((CheckBox)o).Checked)
            {
                settingsTranslucent.Checked = true;
            }
            //Unchecking basic (logically) disables when max
            if (((Control)o).Name == "settingsTranslucent" && !((CheckBox)o).Checked)
            {
                settingsTransMax.Checked = false;
            }
            if (settingsTranslucent.Checked && (this.WindowState != FormWindowState.Maximized || settingsTransMax.Checked))
            {
                this.Opacity = 0.9;
            }
            else
            {
                this.Opacity = 1;
            }
        }
        void browseForXMLEditor(object o, LinkLabelLinkClickedEventArgs e)
        {
            var fileOpen = new OpenFileDialog();
            fileOpen.Filter = "Programs and batch files (*.exe,*.com,*.cmd,*.bat)|*.exe;*.com;*.cmd;*.bat";
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                settingsEditorPath.Text = fileOpen.FileName;
            }
            fileOpen.Dispose();
        }

        void goToLI(object o, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lotrointerface.com/downloads/info623-BuildSkin.html");
        }
        void goToMevordel(object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void goToMITLicense(object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void openReadMe(object o, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.IO.FileInfo(".\\Readme.txt").FullName);
        }

        string lastSkin = string.Empty;
        XmlDocument skinXML = new XmlDocument();
        bool firstRun = true;
    }
}
