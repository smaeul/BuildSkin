using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuildSkin
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();

            //FIXME: HACKY
            optionDefaultRes.SelectedIndex = optionDefaultRes.Items.IndexOf("1024x768"); ;

            //Must load in this order
            RefreshOptions();
            RefreshPresets();
            LoadSettings();

            //Apply Settings
            UpdateTransparency(new Control(), new EventArgs());
            if (optionAutoLoad.Checked && presetList.Items.Contains(lastSkin))
            {
                presetList.SelectedIndex = presetList.Items.IndexOf(lastSkin);
            }
        }
        void OnClose(Object o, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        void AddPreset(Object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void DeletePreset(Object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void RenamePreset(Object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void CopyPreset(Object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void FilterPresets(Object o, EventArgs e)
        {

        }
        void SelectPreset(Object o, EventArgs e)
        {
            presetPreview.Navigate("Presets\\" + presetList.Items[presetList.SelectedIndex].ToString() + ".html");
            LoadCustom(presetList.Items[presetList.SelectedIndex].ToString());
        }

        void LoadCustom(Object o, LinkLabelLinkClickedEventArgs e)
        {
            if (presetList.SelectedIndex >= 0)
            {
                LoadCustom(presetList.Items[presetList.SelectedIndex].ToString());
            }
        }
        void LoadCustom(String name)
        {

        }
        void SaveCustom(Object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void FilterElements(Object o, EventArgs e)
        {

        }

        void RefreshAddons(Object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void UpdateAddons(Object o, LinkLabelLinkClickedEventArgs e)
        {
            //RemoveAddon();
            //InstallAddon();
        }
        void DeleteAllAddons(Object o, LinkLabelLinkClickedEventArgs e)
        {

        }
        void FilterAddons(Object o, EventArgs e)
        {

        }
        void InstallAddon(Object o, EventArgs e)
        {

        }
        void RemoveAddon(Object o, EventArgs e)
        {

        }

        void SaveSettings(Object o, LinkLabelLinkClickedEventArgs e)
        {
            SaveSettings();
        }
        void SaveSettings()
        {
            System.IO.File.WriteAllLines(".\\BuildSkin.conf", new string[] {
                optionTranslucent.Checked.ToString().ToLowerInvariant(),
                optionTransMax.Checked.ToString().ToLowerInvariant(),
                optionAutoLoad.Checked.ToString().ToLowerInvariant(),
                optionConfirmation.Checked.ToString().ToLowerInvariant(),
                optionNoRecycle.Checked.ToString().ToLowerInvariant(),
                optionReadOnly.Checked.ToString().ToLowerInvariant(),
                optionEditorPath.Text,
                optionDefaultRes.Items.ToString(),
                optionDefaultRes.SelectedItem.ToString(),
                lastSkin
            });
        }
        void ReloadSettings(Object o, LinkLabelLinkClickedEventArgs e)
        {
            LoadSettings();
        }
        void LoadSettings()
        {
            //Load From File

        }
        void BrowseForEditor(Object o, EventArgs e)
        {
            var fileOpen = new OpenFileDialog();
            fileOpen.Filter = "Programs and batch files (*.exe,*.com,*.cmd,*.bat)|*.exe;*.com;*.cmd;*.bat";
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                optionEditorPath.Text = fileOpen.FileName;
            }
            fileOpen.Dispose();
        }
        void UpdateTransparency(Object o, EventArgs e)
        {
            //Checking "Even when maximized" enables basic translucency
            if (((Control)o).Name == "optionTransMax" && ((CheckBox)o).Checked)
            {
                optionTranslucent.Checked = true;
            }
            if (((Control)o).Name == "optionTranslucent" && ((CheckBox)o).Checked == false)
            {
                optionTransMax.Checked = false;
            }
            if (optionTranslucent.Checked && (this.WindowState != FormWindowState.Maximized || optionTransMax.Checked))
            {
                this.Opacity = 0.9;
            }
            else
            {
                this.Opacity = 1;
            }
        }

        void RefreshOptions(Object o, EventArgs e)
        {

        }
        void RefreshOptions()
        {

        }
        void RefreshPresets(Object o, EventArgs e)
        {

        }
        void RefreshPresets()
        {

        }

        string lastSkin; //Loaded from Config file
    }
}