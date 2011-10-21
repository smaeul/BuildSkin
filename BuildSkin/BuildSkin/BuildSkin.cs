﻿using System;
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
        public void OnClose(object oSender, FormClosingEventArgs e)
        {
            SaveOptions();
        }
        public void LoadSkin(object oSender, EventArgs e)
        {
            LoadSkin(tSkinName.Text);
        }
        public void LoadSkin(string sName)
        {
            //Load From file
            if (System.IO.File.Exists(sName + " Skin\\SkinDefinition.BuildSkin"))
            {
                string[] sElements = System.IO.File.ReadAllLines(sName + " Skin\\SkinDefinition.BuildSkin"); //Same order as oAllBoxes (+ 2 for resolutions)
                
                //Load Resolution
                if (oResolutionMain.Items.Contains(sElements[0]))
                {
                    oResolutionMain.SelectedIndex = oResolutionMain.Items.IndexOf(sElements[0]);
                }
                if (oResolutionToolbar.Items.Contains(sElements[1]))
                {
                    oResolutionToolbar.SelectedIndex = oResolutionToolbar.Items.IndexOf(sElements[1]);
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
        public void BuildSkin(object oSender, EventArgs e)
        {
            //Open (Create/Overwrite) Files for writing
            System.IO.Directory.CreateDirectory(tSkinName.Text + " Skin\\");
            System.IO.StreamWriter fXMLFile = new System.IO.StreamWriter(tSkinName.Text + " Skin\\SkinDefinition.xml", false);
            System.IO.StreamWriter fConfFile = new System.IO.StreamWriter(tSkinName.Text + " Skin\\SkinDefinition.BuildSkin", false);

            //Save resolution
            fConfFile.WriteLine(oResolutionMain.Text);
            fConfFile.WriteLine(oResolutionToolbar.Text);

            //XML Header
            fXMLFile.WriteLine("<opt><SkinName Name=\"" + tSkinName.Text + "\" />");

            //Write content to files
            //Use for to preserve order
            foreach (ComboBox oCurrBox in oAllBoxes)
            {
                fConfFile.WriteLine(oCurrBox.Tag + "=" + oCurrBox.Text);
                if (oCurrBox.Text == "Default" && ! Options.ExplicitDefaults) { continue; }
                if (System.IO.File.Exists(oCurrBox.Tag + "\\" + oCurrBox.Text + ".xml"))
                {
                    if (System.IO.File.Exists(oCurrBox.Tag + "\\" + oCurrBox.Text + "res\\resenable.xml"))
                    {
                        if (((String)oCurrBox.Tag) == "Toolbar")
                        {
                            fXMLFile.WriteLine(System.IO.File.ReadAllText(oCurrBox.Tag + "\\" + oCurrBox.Text + "res\\" + oCurrBox.Text + " " + oResolutionToolbar.Text + ".xml"));
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
            }

            //XML Footer
            fXMLFile.WriteLine("</opt> <!-- Built by BuildSkin -->");

            //Close Files
            fConfFile.Close();
            fXMLFile.Close();

            MessageBox.Show("Skin " + tSkinName.Text + " successfully built/updated.");
        }
        public void EditSkin(object oSender, EventArgs e)
        {
            if (System.IO.File.Exists(tSkinName.Text + " Skin\\SkinDefinition.xml") && System.IO.File.Exists(Options.EditorPath))
            {
                System.Diagnostics.Process procEditor = new System.Diagnostics.Process();
                procEditor.StartInfo = new System.Diagnostics.ProcessStartInfo(Options.EditorPath, "\"" + tSkinName.Text + " Skin\\SkinDefinition.xml\"");
                procEditor.Start();
                procEditor.WaitForExit();
            }
            else
            {
                ErrorMessage(0);
            }
        }
        public void DeleteSkin(object oSender, EventArgs e)
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
        public void Preview(object oSender, EventArgs e)
        {
            pPreview.ImageLocation = ((ComboBox)oSender).Tag.ToString() + "\\Preview\\" + ((ComboBox)oSender).SelectedItem.ToString() + ".jpg";
        }
        public void LoadOptions()
        {
            //Read From File to Variables
            if (System.IO.File.Exists(".\\BuildSkin.conf"))
            {
                string[] oFileContents = System.IO.File.ReadAllLines(".\\BuildSkin.conf");
                Options.EditorPath = oFileContents[0];
                Options.LastSkin = oFileContents[1];
                Options.AvailRes = oFileContents[2].Split(',');
                Options.AvailToolbarRes = oFileContents[3].Split(',');
                Options.ExplicitDefaults = (oFileContents[4].ToLowerInvariant() == "true");
                Options.AutoLoadLast = (oFileContents[5].ToLowerInvariant() == "true");
            }
            else //Load Defaults
            {
                Options.EditorPath = "C:\\Windows\\Notepad.exe";
                Options.LastSkin = null;
                Options.AvailRes = new string[] { "800x600", "1024x768", "1152x768", "1280x720", "1280x1024", "1366x768", "1440x900", "1600x900", "1680x1024", "1680x1050", "1920x1080", "1920x1200", "2048x1080", "2048x1536", "2560x1600", "2560x2048" };
                Options.AvailToolbarRes = new string[] { "800", "1024", "1152", "1280", "1366", "1440", "1600", "1680", "1920", "2048", "2560" };
                Options.ExplicitDefaults = false;
                Options.AutoLoadLast = true;
            }

            //Apply
            oResolutionMain.Items.AddRange(Options.AvailRes);
            oResolutionToolbar.Items.AddRange(Options.AvailToolbarRes);
            tSkinName.Text = Options.LastSkin;
            if (Options.AutoLoadLast && Options.LastSkin != null) { LoadSkin(Options.LastSkin); }
        }
        public void SaveOptions()
        {
            //Set Vars
            Options.LastSkin = tSkinName.Text;

            //Save to File
            string sAvailRes = String.Join(",", Options.AvailRes);
            string sAvailToolbarRes = String.Join(",", Options.AvailToolbarRes);
            string[] sOptions = {
                                    Options.EditorPath,
                                    Options.LastSkin,
                                    sAvailRes,
                                    sAvailToolbarRes,
                                    Options.ExplicitDefaults.ToString(),
                                    Options.AutoLoadLast.ToString()
                                };
            System.IO.File.WriteAllLines("BuildSkin.conf", sOptions);
        }
        public void ErrorMessage(int iType)
        {
            MessageBox.Show("There was an error of type " + iType + ".");
        }
        public void RefreshAll()
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
        public void AboutWindow()
        {
            MessageBox.Show("Copyright 2011 Mevordel.", "About");
        }
        public void OptionsWindow()
        {
            MessageBox.Show("Not Implemented", "Options");
        }
        public struct Options
        {
            public static string EditorPath;
            public static string LastSkin;
            public static string[] AvailRes;
            public static string[] AvailToolbarRes;
            public static bool ExplicitDefaults;
            public static bool AutoLoadLast;
        }
        public static ComboBox[] oAllBoxes = new ComboBox[52];
    }
}