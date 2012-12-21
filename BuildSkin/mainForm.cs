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
using SevenZip;

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
            //Initialize Table And Skins List
            skinRefreshList();
            skinFillTable();

            //Fill Addons Table
            addonRefreshLocal(new object(), new LinkLabelLinkClickedEventArgs(new LinkLabel.Link()));
            addonRefreshRemote(new object(), new LinkLabelLinkClickedEventArgs(new LinkLabel.Link()));

            //Set Default Resolution
            settingsResolution.SelectedIndex = 1;

            //Load Settings From File
            settingLoad(new object(), new LinkLabelLinkClickedEventArgs(new LinkLabel.Link()));

            //Apply Settings
            updateOpacity(new Control(), new EventArgs());
            if (settingsAutoLoad.Checked && lastSkin != string.Empty && skinsList.Items.Contains(lastSkin))
                skinsList.SelectedIndex = skinsList.Items.IndexOf(lastSkin); //This Also Loads The Skin (Due To onSelectedIndexChanged())
            
            //Display First Run Help Dialog
            if (firstRun)
            {
                MessageBox.Show("Thank you for downloading BuildSkin. First set your resolution on the settings tab. Then go to the addons tab and download what you find interesting.\n\n" +
                "To create your customized skin, go to the skins tab, enter a name, select what you want from the right column, and click build.\n\n" +
                "If anything confuses you, please refer to the resources in the information tab section.", "Welcome to BuildSkin!");
                firstRun = false;
            }
        }
        void mainFormClose(object o, FormClosingEventArgs e)
        {
            //Save Our Settings
            settingSave(new object(), new LinkLabelLinkClickedEventArgs(new LinkLabel.Link()));

            //Save Local Plugins
            addonSaveLocal();
        }

        void skinBuild(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Verify Valid Skin Name
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }
            
            //Check For Existing Skin, Only Overwriting If Configured To
            if (!System.IO.Directory.Exists("./Skins/" + skinsList.Text) || !settingsConfirmation.Checked ||
                MessageBox.Show("Do you want to overwrite the previous skin?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //Set Up A Few Variables
                List<string> configLines = new List<string>();
                XmlReaderSettings xrs = new XmlReaderSettings();
                xrs.ConformanceLevel = ConformanceLevel.Fragment;

                //Initialize XML Tree (Root Element & Skin Name)
                skinXML.RemoveAll();
                skinXML.LoadXml("<?xml version=\"1.0\"?><opt><SkinName Name=\"" + skinsList.Text + "\" /></opt>");

                //Initialize Progress Bar
                statusProgress.Minimum = 0;
                statusProgress.Value = 0;
                statusProgress.Maximum = skinsCustomize.RowCount;

                //Iterate Through Skin Elements
                foreach (DataGridViewRow row in skinsCustomize.Rows)
                {
                    statusProgress.Increment(1);

                    //Make Sure Chosen Option Is Valid
                    if (row.Cells["customOptions"].Value.ToString() != "--" && System.IO.File.Exists("./Elements/" + row.Cells["customCategory"].Value.ToString() + "/" +
                        row.Cells["customName"].Value.ToString() + "/" + row.Cells["customOptions"].Value.ToString() + ".xml"))
                    {
                        //Save Skin Configuration
                        configLines.Add(row.Cells["customCategory"].Value.ToString() + ">" + row.Cells["customName"].Value.ToString() + "=" + row.Cells["customOptions"].Value.ToString());
                        
                        //Read Elements And Add To XML Tree
                        XmlReader reader = XmlReader.Create("./Elements/" + row.Cells["customCategory"].Value.ToString() + "/" + row.Cells["customName"].Value.ToString() + "/" +
                            row.Cells["customOptions"].Value.ToString() + ".xml", xrs);
                        while (reader.Read())
                            if (reader.NodeType == XmlNodeType.Element)
                                skinXML.DocumentElement.AppendChild(skinXML.ReadNode(reader.ReadSubtree()));
                    }
                }

                //Get List Of All Elements
                XmlNodeList nodes = skinXML.SelectNodes("//Element/@*");

                //Initialize Progress Bar
                statusProgress.Minimum = 0;
                statusProgress.Maximum = nodes.Count;
                statusProgress.Value = 0;
                
                //Replace Expressions With Values
                foreach (XmlAttribute node in nodes)
                {
                    statusProgress.Increment(1);
                
                    //Check For Magic Character "{"
                    if (node.Name != "ID" && node.Value.Contains("{"))
                        node.Value = resolveVars(node.Value);
                }

                //Write Files
                System.IO.Directory.CreateDirectory("./Skins/" + skinsList.Text);
                System.IO.File.WriteAllLines("./Skins/" + skinsList.Text + "/BuildSkin", configLines.ToArray());
                skinXML.Save("./Skins/" + skinsList.Text + "/SkinDefinition.xml");

                //Finish Up
                skinRefreshList();
                statusText.Text = "Skin " + skinsList.Text + " built successfully!";
            }
        }
        string resolveVars(string expr)
        {
            //Clean Braces And Non-Variable Characters Out Of String
            expr = expr.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)[0];
            string[] vars = expr.Split(new char[] { ',', '+', '-', '*', '/', '(', ')', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }, StringSplitOptions.RemoveEmptyEntries);
            
            //Iterate Through Unresolved Variables, Replacing
            //
            //TODO: As String.Replace() replaces all instances of a variable, we will go through this loop more times than necessary. Maybe add more recursion and only do vars[0]?
            //
            foreach (string var in vars)
            {
                //Most Specific Case
                if (var.Split('.')[0].ToLowerInvariant() == "screen")
                {
                    //Width
                    if (var.Split('.')[1].ToLowerInvariant().StartsWith("w"))
                        expr = expr.Replace(var, settingsResolution.Text.Split('x')[0]);
                    
                    //Height
                    else if (var.Split('.')[1].ToLowerInvariant().StartsWith("h"))
                        expr = expr.Replace(var, settingsResolution.Text.Split('x')[1]);

                    //Gracefully Handle Unknown Screen Property
                    else
                        expr = expr.Replace(var, "0");
                }

                //Otherwise It Should Be Some Node's ID
                else if (skinXML.SelectSingleNode("//Element[@ID='" + var.Split('.')[0] + "']") != null)
                {
                    //Find Correct Attribute (Width/Height/X/Y)
                    //
                    //TODO: This could probably be done better with indexes or XPath
                    //
                    foreach (XmlAttribute attr in skinXML.SelectSingleNode("//Element[@ID='" + var.Split('.')[0] + "']").Attributes)
                    {
                        if (attr.Name.StartsWith(var.Split('.')[1].Substring(0, 1)))
                        {
                            //When Recursing, Resolve Variables At Their Source So They Are Only Done Once
                            attr.Value = resolveVars(attr.Value);
                            expr = expr.Replace(var, attr.Value);
                        }
                    }
                }
                
                //We Don't Know What This Variable Is
                else
                {
                    expr = expr.Replace(var, "0");
                }
            }

            //Perform Mathematical Operations, Rounding As We Go
            return new Expression("Round(" + expr + ",0)").Evaluate().ToString();
        }
        void skinRename(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Validate Skin Name
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }

            //Prompt User For Input
            Form fRename = new Form();
            fRename.Width = 320;
            fRename.Height = 72;
            fRename.Text = "Rename Skin";
            Label lRename = new Label() { Left=10, Top=11, Text="New Name:", Width=70 };
            TextBox tRename = new TextBox() { Left=90, Top=8, Width=140, Text=skinsList.Text };
            Button bRename = new Button() { Text="Ok", Left=240, Width=50, Top=6 };
            bRename.Click += (sender, ev) => { fRename.Close(); };
            fRename.Controls.Add(bRename);
            fRename.Controls.Add(lRename);
            fRename.Controls.Add(tRename);
            fRename.ShowDialog();

            //Clean Up Dialog
            string newName = tRename.Text;
            fRename.Dispose();

            //If The User Left The Box Blank Or The Same, Assume He Wants To Cancel
            if (newName == string.Empty || newName == skinsList.Text)
                return;

            //Rename The Skin
            if (!System.IO.Directory.Exists("Skins/" + newName) || !settingsConfirmation.Checked ||
                MessageBox.Show("Are you sure you want to overwrite the skin '" + newName + "'?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.IO.Directory.Move("Skins/" + skinsList.SelectedItem, "Skins/" + newName);
                statusText.Text = "Skin " + skinsList.SelectedItem + " successfully renamed to " + newName + "!";
            }

            //Refresh List
            skinRefreshList();

            //Select New Skin
            skinsList.SelectedIndex = skinsList.Items.IndexOf(newName);
        }
        void skinDelete(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Validate Skin Name
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }

            if (!settingsConfirmation.Checked ||
                MessageBox.Show("Are you sure you want to delete the skin '" + skinsList.SelectedItem + "'?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (settingsNoRecycle.Checked)
                {
                    if (System.IO.Directory.Exists("Skins/" + skinsList.SelectedItem))
                    {
                        System.IO.Directory.Delete("Skins/" + skinsList.SelectedItem, true);
                        statusText.Text = "Skin " + skinsList.SelectedItem + " successfully deleted!";
                    }
                }
                else
                {
                    MessageBox.Show("I haven't teched up to recycling centers yet, so you'll have to either delete directly or delete manually outside the program.");
                }
            }

            //Refresh List
            skinRefreshList();
        }
        void skinEditXML(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Validate Skin Name
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }

            //Check For Required Files
            if (System.IO.File.Exists("./Skins/" + skinsList.SelectedItem + "/SkinDefinition.xml") && System.IO.File.Exists(settingsEditorPath.Text))
            {
                //Start Editor (Do Not Wait For Exit)
                System.Diagnostics.Process procEditor = new System.Diagnostics.Process();
                procEditor.StartInfo = new System.Diagnostics.ProcessStartInfo(settingsEditorPath.Text, "\"Skins/" + skinsList.SelectedItem + "/SkinDefinition.xml\"");
                procEditor.Start();
            }
        }
        void skinReload(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Validate Skin Name
            if (skinsList.Text == string.Empty)
            {
                MessageBox.Show("The skin name cannot be empty.");
                return;
            }

            //Clear Table (probably more efficient than calling the function)
            foreach (DataGridViewRow row in skinsCustomize.Rows)
                row.Cells["customOptions"].Value = "--";
            
            //Refill Table
            if (System.IO.File.Exists("./Skins/" + skinsList.SelectedItem + "/BuildSkin"))
                foreach (string line in System.IO.File.ReadAllLines("./Skins/" + skinsList.SelectedItem + "/BuildSkin"))
                    foreach (DataGridViewRow row in skinsCustomize.Rows)
                        if (row.Cells["customCategory"].Value.ToString() + ">" + row.Cells["customName"].Value.ToString() == line.Split('=')[0])
                        {
                            if (((DataGridViewComboBoxCell)row.Cells["customOptions"]).Items.Contains(line.Split('=')[1]))
                                row.Cells["customOptions"].Value = line.Split('=')[1];
                            break;
                        }
        }
        void skinClear(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Set All Options To "Null" Value
            foreach (DataGridViewRow row in skinsCustomize.Rows)
                row.Cells["customOptions"].Value = "--";
        }
        void skinSelect(object o, EventArgs e)
        {
            //Make Sure Something Is Actually Selected
            if (skinsList.SelectedIndex != -1)
                //Reuse Code To Load Skin
                skinReload(new object(), new LinkLabelLinkClickedEventArgs(new LinkLabel.Link()));
        }
        void skinRefreshList()
        {
            //Save Current Selection
            string current = skinsList.Text;

            //Clear And Re-Add Items
            skinsList.Items.Clear();
            skinsList.Text = String.Empty;

            if (System.IO.Directory.Exists("Skins"))
                foreach (string skin in System.IO.Directory.GetDirectories("./Skins"))
                    //Remove "./Skins/" From Each Item
                    skinsList.Items.Add(skin.Remove(0, 8));

            //Reselect Original Item
            if (skinsList.Items.Contains(current))
                skinsList.SelectedItem = current;
        }
        void skinFillTable()
        {
            //Clear Table (Remove All Rows)
            skinsCustomize.Rows.Clear();

            //Make Sure Directory Exists
            if (System.IO.Directory.Exists("Elements"))
                //Iterate Through Each Element In Each Category
                foreach (string category in System.IO.Directory.GetDirectories("Elements"))
                    foreach (string element in System.IO.Directory.GetDirectories(category))
                    {
                        //Add Row With Name And Category (Minus Leading Paths)
                        skinsCustomize.Rows.Add(category.Replace("Elements\\", string.Empty), element.Replace(category + "\\", string.Empty));

                        //Populate Options
                        foreach (string option in System.IO.Directory.GetFiles(element, "*.xml"))
                            ((DataGridViewComboBoxCell)skinsCustomize.Rows[skinsCustomize.RowCount - 1].Cells["customOptions"]).Items.Add(option.Replace(element + "\\", string.Empty).Replace(".xml", string.Empty));
                        ((DataGridViewComboBoxCell)skinsCustomize.Rows[skinsCustomize.RowCount - 1].Cells["customOptions"]).Items.Add("--");
                        ((DataGridViewComboBoxCell)skinsCustomize.Rows[skinsCustomize.RowCount - 1].Cells["customOptions"]).Value = "--";
                    }
        }
        void skinSelectItem(object o, EventArgs e)
        {
            //Show blank, instead of error, for default values ('--')
            if (!((ComboBox)o).SelectedItem.ToString().Equals("--"))
                skinsPreview.ImageLocation = "Elements/" + skinsCustomize.Rows[skinsCustomize.CurrentRow.Index].Cells["customCategory"].Value.ToString() + "/" +
                    skinsCustomize.Rows[skinsCustomize.CurrentRow.Index].Cells["customName"].Value.ToString() + "/" +
                    ((ComboBox)o).SelectedItem.ToString() + ".jpg";
            else
                skinsPreview.ImageLocation = String.Empty;
        }
        void skinOptionEditing(object o, DataGridViewEditingControlShowingEventArgs e)
        {
            //Only Do This For The ComboBoxComumn
            if (skinsCustomize.CurrentCell.ColumnIndex == skinsCustomize.Columns["customOptions"].Index)
            {
                //First remove event handler to keep from attaching multiple
                ((ComboBox)e.Control).SelectedIndexChanged -= new EventHandler(skinSelectItem);

                //Now attach the event handler
                ((ComboBox)e.Control).SelectedIndexChanged += new EventHandler(skinSelectItem);
            }
        }

        void addonFilter(object o, EventArgs e)
        {
            //Show Matching And Hide Non-Matching Rows
            foreach (DataGridViewRow row in addonsDataGrid.Rows)
                if (row.Cells["addonsName"].Value.ToString().ToLowerInvariant().Contains(addonsFilter.Text.ToLowerInvariant()))
                    row.Visible = true;
                else
                    row.Visible = false;
        }
        void addonRefreshRemote(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Download Remote List
            DataSet rssData = new DataSet();
            rssData.ReadXml(System.Net.HttpWebRequest.Create("http://api.lotrointerface.com/fav/Mevordel.xml").GetResponse().GetResponseStream());
            
            //Update and Fill Table
            int found = 0;
            foreach (DataRow item in rssData.Tables["Ui"].Rows)
            {
                string id = item["UID"].ToString();
                string author = item["UIAuthorName"].ToString();
                string name = item["UIName"].ToString();
                string desc = item["UIDescription"].ToString();
                string remoteVer = item["UIVersion"].ToString();
                string link = "http://www.lotrointerface.com/downloads/info" + item["UID"].ToString();
                string file = item["UIFile"].ToString();

                foreach (DataGridViewRow row in addonsDataGrid.Rows)
                    //If This Addon Is Already In The Table
                    if (row.Cells["addonsName"].Value.ToString() == name)
                    {
                        //Record Latest Data - Assume Remote is newest
                        row.Cells["addonsAuthor"].Value = author;
                        row.Cells["addonsName"].Value = name;
                        row.Cells["addonsDesc"].Value = desc;
                        row.Cells["addonsVersion"].Value = remoteVer;
                        row.Cells["addonsFile"].Value = file;
                        
                        //Select Outdated Addons
                        if (row.Cells["addonsInstVer"].Value.ToString() != String.Empty &&
                            row.Cells["addonsInstVer"].Value.ToString() != row.Cells["addonsVersion"].Value.ToString())
                            row.Cells["addonsSelected"].Value = true;
                        
                        //Stop Looking and Don't Add It
                        found = 1;
                        break;
                    }
                
                if (found == 0)
                    //If Not Found, Add The Row
                    addonsDataGrid.Rows.Add(false, false, id, author, name, desc, remoteVer, String.Empty, link, file);
                else
                    //Reset For Next Addon
                    found = 0;
            }
        }
        void addonRefreshLocal(object o, LinkLabelLinkClickedEventArgs e)
        {
            if (System.IO.File.Exists("LocalAddons.conf"))
            {
                //Read Local List
                List<string> localList = new List<string>();
                localList.AddRange(System.IO.File.ReadAllLines("LocalAddons.conf"));

                //Fill and Update Table
                int found = 0;
                foreach (string addon in localList)
                {
                    string[] data = addon.Split(',');

                    foreach (DataGridViewRow row in addonsDataGrid.Rows)
                        //If This Addon Is Already In The Table
                        if (row.Cells["addonsID"].Value.ToString() == data[0])
                        {
                            //Record Installed Version
                            row.Cells["addonsInstVer"].Value = data[4];

                            //Select Outdated Addons
                            if (row.Cells["addonsInstVer"].Value.ToString() != row.Cells["addonsVersion"].Value.ToString())
                                row.Cells["addonsSelected"].Value = true;

                            //Stop Looking and Don't Add It
                            found = 1;
                            break;
                        }
                    
                    if (found == 0)
                        //If Not Found, Add The Row
                        addonsDataGrid.Rows.Add(false, true, data[0], data[1], data[2], String.Empty, String.Empty, data[3], String.Empty, data[4]);
                    else
                        //Reset For Next Addon
                        found = 0;
                }
            }
        }
        void addonSaveLocal()
        {
            List<string> localList = new List<string>();

            foreach (DataGridViewRow row in addonsDataGrid.Rows)
                if (row.Cells["addonsInstalled"].Value.ToString() == "True")
                    localList.Add(String.Join(",", new string[] {
                        row.Cells["addonsID"].Value.ToString(),
                        row.Cells["addonsAuthor"].Value.ToString(),
                        row.Cells["addonsName"].Value.ToString(),
                        row.Cells["addonsInstVer"].Value.ToString(),
                        row.Cells["addonsFile"].Value.ToString()
                    }));

            System.IO.File.WriteAllLines("LocalAddons.conf", localList.ToArray());
        }
        void addonDelete(object o, LinkLabelLinkClickedEventArgs e)
        {
            if (settingsConfirmation.Checked && MessageBox.Show("Are you sure you want to delete the selected Addons?", "Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            //Loop through selected rows
            foreach (DataGridViewRow row in addonsDataGrid.Rows)
                if ((bool)row.Cells["addonsSelected"].Value == true)
                    if ((bool)row.Cells["addonsInstalled"].Value == true)
                    {
                        //Delete The Files
                        addonDeleteSingle(row.Index);

                        //Clean Up Table
                        row.Cells["addonsInstVer"].Value = String.Empty;
                        row.Cells["addonsInstalled"].Value = false;
                        row.Cells["addonsSelected"].Value = false;
                    }
                    else
                        MessageBox.Show("The Addon \"" + row.Cells["addonsName"].Value.ToString() + "\" was not installed previously and cannot be deleted.", "Oops!");

            //Refresh Available Skin Elements
            skinFillTable();

            statusText.Text = "Addons were deleted successfully!";
        }
        void addonDeleteSingle(int rowIndex)
        {
            string id = addonsDataGrid.Rows[rowIndex].Cells["addonsID"].Value.ToString();
            List<string> dirs = new List<string>();

            if (System.IO.File.Exists("Addons/" + id + ".conf"))
            {
                //Remove Files First
                foreach (string file in System.IO.File.ReadAllLines("Addons/" + id + ".conf"))
                {
                    if ((System.IO.File.GetAttributes(file) & System.IO.FileAttributes.Directory) == System.IO.FileAttributes.Directory)
                        //Save Processing Directories For Later
                        dirs.Add(file);
                    else
                        System.IO.File.Delete(file);
                }

                //Remove Empty Directories
                foreach (string dir in dirs)
                    if (System.IO.Directory.Exists(dir) &&
                        System.IO.Directory.GetFiles(dir, "*", System.IO.SearchOption.AllDirectories).Length == 0)
                        System.IO.Directory.Delete(dir, true);

                //Delete file list
                System.IO.File.Delete("Addons/" + id + ".conf");
            }
            else
                MessageBox.Show("The addon " + addonsDataGrid.Rows[rowIndex].Cells["addonsName"].Value.ToString() +
                    " was not installed by BuildSkin and therefore cannot be deleted by it.");
        }
        void addonInstUpd(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Set Up Progress Bar
            statusProgress.Minimum = 0;
            statusProgress.Maximum = addonsDataGrid.Rows.Count;
            statusProgress.Value = 0;

            //Loop through selected rows
            foreach (DataGridViewRow row in addonsDataGrid.Rows)
            {
                if ((bool)row.Cells["addonsSelected"].Value == true)
                {
                    //If We Are Updating, Remove It First
                    if ((bool)row.Cells["addonsInstalled"].Value == true)
                        addonDeleteSingle(row.Index);

                    //Set Up
                    System.IO.Directory.CreateDirectory("Addons");
                    string file = "Addons/" + row.Cells["addonsFile"].Value.ToString();

                    if (!System.IO.File.Exists(file))
                    {
                        //Download
                        statusText.Text = "Downloading " + row.Cells["addonsFile"].Value.ToString();
                        System.Net.WebClient client = new System.Net.WebClient();
                        client.DownloadFile("http://www.lotrointerface.com/downloads/download" + row.Cells["addonsID"].Value.ToString(), file);

                        //Move Progress Bar (but make sure it still ends at 100%)
                        statusProgress.Maximum = statusProgress.Maximum + 1;
                        statusProgress.Increment(1);
                        Application.DoEvents();
                    }

                    //Move Progress Bar (but make sure it still ends at 100%)
                    statusProgress.Maximum = statusProgress.Maximum + 1;
                    statusProgress.Increment(1);
                    statusText.Text = "Extracting " + row.Cells["addonsFile"].Value.ToString();
                    Application.DoEvents();

                    //Extract
                    SevenZipExtractor zip = new SevenZipExtractor(file);
                    zip.PreserveDirectoryStructure = true;
                    zip.ExtractArchive(".");

                    //Save File List
                    string[] files = new string[zip.ArchiveFileNames.Count];
                    zip.ArchiveFileNames.CopyTo(files, 0);
                    System.IO.File.WriteAllLines("Addons/" + row.Cells["addonsID"].Value.ToString() + ".conf", files);

                    //Set Installed + Version
                    row.Cells["addonsInstVer"].Value = row.Cells["addonsVersion"].Value;
                    row.Cells["addonsInstalled"].Value = true;
                    row.Cells["addonsSelected"].Value = false;
                }

                statusProgress.Increment(1);
            }

            //Refresh Available Skin Elements
            skinFillTable();

            statusText.Text = "Addons were installed/updated successfully!";
        }
        void addonSelectAll(object o, EventArgs e)
        {
            //Uncheck All
            foreach (DataGridViewRow row in addonsDataGrid.Rows)
                row.Cells["addonsSelected"].Value = false;

            //If We Are Checking, Check Those That Need To Be Updated
            if (addonsSelectAll.CheckState == CheckState.Checked)
                foreach (DataGridViewRow row in addonsDataGrid.Rows)
                    if (row.Cells["addonsInstVer"].Value.ToString() != String.Empty &&
                        row.Cells["addonsInstVer"].Value.ToString().ToLowerInvariant() != row.Cells["addonsVersion"].Value.ToString().ToLowerInvariant())
                        row.Cells["addonsSelected"].Value = true;
        }
        void addonSelectRow(object o, EventArgs e)
        {
            //Change Description To That Of The Selected Row
            addonsDescription.Lines = addonsDataGrid.Rows[addonsDataGrid.CurrentRow.Index].Cells["addonsDesc"].Value.ToString().Split('\n');
        }

        void settingLoad(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Load From File, Allowing For Case Differences
            if (System.IO.File.Exists("BuildSkin.conf"))
            {
                string[] configLines = System.IO.File.ReadAllLines("BuildSkin.conf");
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
            //Put Settings In A String Array, And Write To File
            string[] resolutions = new string[settingsResolution.Items.Count];
            settingsResolution.Items.CopyTo(resolutions, 0);
            System.IO.File.WriteAllLines("BuildSkin.conf", new string[] {
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
                settingsTranslucent.Checked = true;

            //Unchecking Ever Disables When Max
            if (((Control)o).Name == "settingsTranslucent" && !((CheckBox)o).Checked)
                settingsTransMax.Checked = false;

            //Set Opacity
            if (settingsTranslucent.Checked && (this.WindowState != FormWindowState.Maximized || settingsTransMax.Checked))
                this.Opacity = 0.9;
            else
                this.Opacity = 1;
        }
        void browseForXMLEditor(object o, LinkLabelLinkClickedEventArgs e)
        {
            //Create Dialog
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "Programs and batch files (*.exe,*.com,*.cmd,*.bat)|*.exe;*.com;*.cmd;*.bat";
            
            //If OK Was Selected, Set Path From Result
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                settingsEditorPath.Text = fileOpen.FileName;

            //Clean Up
            fileOpen.Dispose();
        }

        void goToLI(object o, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lotrointerface.com/downloads/info623-BuildSkin.html");
        }
        void goToMevordel(object o, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: Make Real Website :)
            //System.Diagnostics.Process.Start("http://mevordel.usgrd.com/");
        }
        void goToMITLicense(object o, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Copyright (c) 2011-2012 Samuel Holland\n\nPermission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the \"Software\"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:\n\nThe above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.\n\nTHE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.", "License");
        }
        void openReadMe(object o, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: Write README
            //Open Default Handler For Text Files
            System.Diagnostics.Process.Start(new System.IO.FileInfo("Readme.txt").FullName);
        }

        //Initial Default/Empty Variables
        string lastSkin = string.Empty;
        List<String> addonListLocal = new List<string>();
        XmlDocument skinXML = new XmlDocument();
        bool firstRun = true;
    }
}
