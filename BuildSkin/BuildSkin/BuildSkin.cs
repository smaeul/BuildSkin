using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuildSkin
{
    public partial class fBuildSkin : Form
    {
        public fBuildSkin()
        {
            InitializeComponent();
            // Fill List of Elements
            short iCount = 0;
            foreach (Control oGroup in sHorizontal.Panel1.Controls)
            {
                foreach (Control oCtrl in oGroup.Controls)
                {
                    if (oCtrl.GetType() == typeof(ComboBox))
                    {
                        oAllBoxes[iCount] = ((ComboBox)oCtrl);
                        iCount++;
                    }
                }
            }
            RefreshAll();
            LoadOptions();
        }
        void OnClose(object oSender, FormClosingEventArgs e)
        {
            SaveOptions();
        }
        void LoadSkin(object oSender, EventArgs e)
        {
            LoadSkin(tSkinName.Text);
        }
        void LoadSkin(string sName)
        {
            if (Options.ConfirmActions == true && MessageBox.Show("Do you want to continue loading this skin? This will overwrite any unsaved work.", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; }
            //Load From file
            if (System.IO.File.Exists(sName + " Skin\\SkinDefinition.BuildSkin"))
            {
                string[] sElements = System.IO.File.ReadAllLines(sName + " Skin\\SkinDefinition.BuildSkin"); //Same order as oAllBoxes (+ 2 for resolutions)
                
                //Load Resolution
                if (oResolutionMain.Items.Contains(sElements[0]))
                {
                    oResolutionMain.SelectedIndex = oResolutionMain.Items.IndexOf(sElements[0]);
                }
                else
                {
                    ErrorMessage(2);
                }

                //Fill in ComboBoxes
                //Must use for to preserve order, offset 2 for resolution lines
                for (short i = 2; i < sElements.Length; i++)
                {
                    string[] sTmp = sElements[i].Split('=');
                    foreach (ComboBox oCurrBox in oAllBoxes)
                    {
                        if (((String)oCurrBox.Tag) == sTmp[0])
                        {
                            if (oCurrBox.Items.Contains(sTmp[1]))
                            {
                                oCurrBox.SelectedIndex = oCurrBox.Items.IndexOf(sTmp[1]);
                            }
                            else
                            {
                                oCurrBox.SelectedIndex = oCurrBox.Items.IndexOf("Default");
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                ErrorMessage(0);
                return;
            }
        }
        void BuildSkin(object oSender, EventArgs e)
        {
            if (Options.ConfirmActions == true && MessageBox.Show("Do you want to continue building this skin? This will overwrite any previous skin with the same name.", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; }
            if (tSkinName.Text == "") { MessageBox.Show("You must type a skin name.", "Error!"); return; }
            if (oResolutionMain.Text == "") { MessageBox.Show("You must choose a resolution.", "Error!"); return; }
            //Open (Create/Overwrite) Files for writing
            try
            {
                System.IO.Directory.CreateDirectory(tSkinName.Text + " Skin\\");
            }
            catch
            {
                ErrorMessage(3);
            }

            try
            {
                System.IO.StreamWriter fXMLFile = new System.IO.StreamWriter(tSkinName.Text + " Skin\\SkinDefinition.xml", false);
                System.IO.StreamWriter fConfFile = new System.IO.StreamWriter(tSkinName.Text + " Skin\\SkinDefinition.BuildSkin", false);

                //Save resolution
                fConfFile.WriteLine(oResolutionMain.Text);
                fConfFile.WriteLine("Deprecated by removal of Toolbar Width");

                //XML Header
                fXMLFile.WriteLine("<opt><SkinName Name=\"" + tSkinName.Text + "\" />");

                //Write content to files
                //Use for to preserve order
                foreach (ComboBox oCurrBox in oAllBoxes)
                {
                    fConfFile.WriteLine(oCurrBox.Tag + "=" + oCurrBox.Text);
                    if (System.IO.File.Exists(oCurrBox.Tag + "\\" + oCurrBox.Text + ".xml"))
                    {
                        if (System.IO.File.Exists(oCurrBox.Tag + "\\" + oCurrBox.Text + "res\\resenable.xml"))
                        {
                            if (((String)oCurrBox.Tag) == "Interface-ToolbarQuickslots")
                            {
                                fXMLFile.WriteLine(System.IO.File.ReadAllText(oCurrBox.Tag + "\\" + oCurrBox.Text + "res\\" + oCurrBox.Text + " " + oResolutionMain.Text.Split('x')[0] + ".xml"));
                            }
                            else
                            {
                                fXMLFile.WriteLine(System.IO.File.ReadAllText(oCurrBox.Tag + "\\" + oCurrBox.Text + "res\\" + oCurrBox.Text + " " + oResolutionMain.Text + ".xml"));
                            }
                        }
                        else
                        {
                            fXMLFile.WriteLine(System.IO.File.ReadAllText(oCurrBox.Tag + "\\" + oCurrBox.Text + ".xml"));
                        }
                    }
                    else
                    {
                        if (oCurrBox.Text != "")
                        {
                            ErrorMessage(5);
                        }
                    }
                }

                //XML Footer
                fXMLFile.WriteLine("</opt> <!-- Built by BuildSkin -->");

                //Close Files
                fConfFile.Close();
                fXMLFile.Close();
            }
            catch
            {
                ErrorMessage(4);
            }

            MessageBox.Show("Skin " + tSkinName.Text + " successfully built/updated.");
            RefreshSkins();
        }
        void EditSkin(object oSender, EventArgs e)
        {
            if (System.IO.File.Exists(tSkinName.Text + " Skin\\SkinDefinition.xml") && System.IO.File.Exists(Options.EditorPath))
            {
                System.Diagnostics.Process procEditor = new System.Diagnostics.Process();
                procEditor.StartInfo = new System.Diagnostics.ProcessStartInfo(Options.EditorPath, "\"" + tSkinName.Text + " Skin\\SkinDefinition.xml\"");
                procEditor.Start();
            }
            else
            {
                ErrorMessage(1);
            }
        }
        void DeleteSkin(object oSender, EventArgs e)
        {
            if (Options.ConfirmActions == true && MessageBox.Show("Are you sure you want to delete this skin?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; }
            try
            {
                if (System.IO.File.Exists(tSkinName.Text + " Skin\\SkinDefinition.xml"))
                {
                    System.IO.File.Delete(tSkinName.Text + " Skin\\SkinDefinition.xml");
                }
                if (System.IO.File.Exists(tSkinName.Text + " Skin\\SkinDefinition.BuildSkin"))
                {
                    System.IO.File.Delete(tSkinName.Text + " Skin\\SkinDefinition.BuildSkin");
                }
                if (System.IO.Directory.Exists(tSkinName.Text + " Skin"))
                {
                    System.IO.Directory.Delete(tSkinName.Text + " Skin");
                }

                MessageBox.Show("Skin " + tSkinName.Text + " deleted.");
            }
            catch
            {
                ErrorMessage(6);
            }
            RefreshSkins();
        }
        void Preview(object oSender, EventArgs e)
        {
            pPreview.ImageLocation = ((ComboBox)oSender).Tag.ToString() + "\\Preview\\" + ((ComboBox)oSender).SelectedItem.ToString() + ".jpg";
        }
        void LoadOptions()
        {
            //Read From File to Variables
            if (System.IO.File.Exists(".\\BuildSkin.conf"))
            {
                try
                {
                    string[] oFileContents = System.IO.File.ReadAllLines(".\\BuildSkin.conf");
                    Options.EditorPath = oFileContents[0];
                    Options.LastSkin = oFileContents[1];
                    Options.AvailRes = oFileContents[2].Split(',');
                    Options.ConfirmActions = (oFileContents[4].ToLowerInvariant() == "true");
                    Options.AutoLoadLast = (oFileContents[5].ToLowerInvariant() == "true");
                }
                catch { ErrorMessage(7); }
            }
            else //Load Defaults
            {
                Options.EditorPath = "C:\\Windows\\Notepad.exe";
                Options.LastSkin = "";
                Options.AvailRes = new string[] {
                      "800x600",  "1024x768",  "1152x768",  "1280x720",
                     "1280x800", "1280x1024",  "1366x768",  "1440x900",
                     "1600x900", "1680x1024", "1680x1050", "1920x1080",
                    "1920x1200", "2048x1080", "2048x1536", "2560x1600", "2560x2048" };
                Options.ConfirmActions = false;
                Options.AutoLoadLast = true;
            }

            //Apply
            oResolutionMain.Items.AddRange(Options.AvailRes);
            //oResolutionMain.SelectedIndex = 1; //Don't want lowest resolution as default, do we?
            tSkinName.Text = Options.LastSkin;
            if (Options.AutoLoadLast && Options.LastSkin != "") { LoadSkin(Options.LastSkin); }
        }
        void SaveOptions()
        {
            //Set Vars
            Options.LastSkin = tSkinName.Text;

            //Save to File
            string[] sOptions = {
                                    Options.EditorPath,
                                    Options.LastSkin,
                                    String.Join(",", Options.AvailRes),
                                    "Deprecated",
                                    Options.ConfirmActions.ToString(),
                                    Options.AutoLoadLast.ToString()
                                };
            try { System.IO.File.WriteAllLines("BuildSkin.conf", sOptions); }
            catch { ErrorMessage(7); }
        }
        void ErrorMessage(int iType)
        {
            switch (iType)
            {
                case 0:
                    MessageBox.Show("Missing SkinDefinition.BuildSkin");
                    break;
                case 1:
                    MessageBox.Show("Missing SkinDefinition.XML");
                    break;
                case 2:
                    MessageBox.Show("Unsupported resolution in loaded skin. Please select another.");
                    break;
                case 3:
                    MessageBox.Show("Error creating skin files. Check to see if they are in use.");
                    break;
                case 4:
                    MessageBox.Show("Error writing to skin files. Check to see if they are in use.");
                    break;
                case 5:
                    MessageBox.Show("Missing element XML snippet. Try restarting the program to refresh.");
                    break;
                case 6:
                    MessageBox.Show("Error deleting skin.  Check to see if it is in use.");
                    break;
                case 7:
                    MessageBox.Show("Error loading or saving options. Check to see if the file is in use.");
                    break;
                case 8:
                    MessageBox.Show("Error opening webpage.");
                    break;
                default:
                    MessageBox.Show("An unkown error has occurred.");
                    break;
            }
        }
        void RefreshAll()
        {
            //Refresh Elements
            foreach (ComboBox oCurrBox in oAllBoxes)
            {
                if (System.IO.Directory.Exists(((string)oCurrBox.Tag)))
                {
                    foreach (string sFile in System.IO.Directory.GetFiles(((string)oCurrBox.Tag), "*.xml"))
                    {
                        oCurrBox.Items.Add(System.IO.Path.GetFileNameWithoutExtension(sFile));
                    }
                    if (oCurrBox.Items.Count > 1) { oCurrBox.Enabled = true; }
                }
            }
            
            //Refresh Skins
            foreach (string sDir in System.IO.Directory.GetDirectories(".", "* Skin"))
            {
                tSkinName.Items.Add(sDir.Remove(sDir.Length - 5).Remove(0,2));
            }
        }
        void RefreshSkins()
        {
            //Refresh Skins
            string sTmp = tSkinName.Text;
            tSkinName.Items.Clear();
            foreach (string sDir in System.IO.Directory.GetDirectories(".", "* Skin"))
            {
                tSkinName.Items.Add(sDir.Remove(sDir.Length - 5).Remove(0, 2));
            }
            if (tSkinName.Items.Contains(sTmp))
            {
                tSkinName.SelectedIndex = tSkinName.Items.IndexOf(sTmp);
            }
        }
        void OptionsWindow(object oSender, EventArgs e)
        {
            OptWinForm oWinForm = new OptWinForm();
            oWinForm.ShowDialog(this);
            if (oWinForm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //Change Options
                Options.AutoLoadLast = ((CheckBox)oWinForm.Controls["cAutoLoad"]).Checked;
                Options.ConfirmActions = ((CheckBox)oWinForm.Controls["cConfirm"]).Checked;
                Options.EditorPath = ((TextBox)oWinForm.Controls["tEditorPath"]).Text;
            }
            oWinForm.Dispose();
        }
        void NavigateToLI(object oSender, LinkLabelLinkClickedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("http://www.lotrointerface.com/downloads/info623-BuildSkin.html"); }
            catch { ErrorMessage(8); }
        }
        public struct Options
        {
            public static string EditorPath;
            public static string LastSkin;
            public static string[] AvailRes;
            public static bool ConfirmActions;
            public static bool AutoLoadLast;
        }
        static ComboBox[] oAllBoxes = new ComboBox[73];
    }
}