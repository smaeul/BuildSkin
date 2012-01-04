namespace BuildSkin
{
    partial class OptWinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.tEditorPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cConfirm = new System.Windows.Forms.CheckBox();
            this.cAutoLoad = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(40, 105);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 1;
            this.bOK.Text = "&OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(160, 105);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "&Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(207, 21);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 4;
            this.bBrowse.Text = "&Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.ClickBrowse);
            // 
            // tEditorPath
            // 
            this.tEditorPath.Location = new System.Drawing.Point(12, 23);
            this.tEditorPath.Name = "tEditorPath";
            this.tEditorPath.Size = new System.Drawing.Size(189, 20);
            this.tEditorPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Editor";
            // 
            // cConfirm
            // 
            this.cConfirm.AutoSize = true;
            this.cConfirm.Location = new System.Drawing.Point(12, 50);
            this.cConfirm.Name = "cConfirm";
            this.cConfirm.Size = new System.Drawing.Size(99, 17);
            this.cConfirm.TabIndex = 5;
            this.cConfirm.Text = "Confirm Actions";
            this.cConfirm.UseVisualStyleBackColor = true;
            // 
            // cAutoLoad
            // 
            this.cAutoLoad.AutoSize = true;
            this.cAutoLoad.Location = new System.Drawing.Point(12, 74);
            this.cAutoLoad.Name = "cAutoLoad";
            this.cAutoLoad.Size = new System.Drawing.Size(162, 17);
            this.cAutoLoad.TabIndex = 6;
            this.cAutoLoad.Text = "Automatically Load Last Skin";
            this.cAutoLoad.UseVisualStyleBackColor = true;
            // 
            // OptWinForm
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(294, 136);
            this.Controls.Add(this.cAutoLoad);
            this.Controls.Add(this.cConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tEditorPath);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptWinForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.TextBox tEditorPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cConfirm;
        private System.Windows.Forms.CheckBox cAutoLoad;
    }
}