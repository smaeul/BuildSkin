using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BuildSkin
{
    public partial class OptWinForm : Form
    {
        public OptWinForm()
        {
            InitializeComponent();
            tEditorPath.Text = fBuildSkin.Options.EditorPath;
            cConfirm.Checked = fBuildSkin.Options.ConfirmActions;
            cAutoLoad.Checked = fBuildSkin.Options.AutoLoadLast;
        }
        void ClickBrowse(object oSender, EventArgs e)
        {
            var ofdOpen = new OpenFileDialog();
            if (ofdOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tEditorPath.Text = ofdOpen.FileName;
            }
            ofdOpen.Dispose();
        }
    }
}
