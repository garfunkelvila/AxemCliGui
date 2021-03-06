﻿namespace AX_Launcher.Dialogs {
    partial class dlgLoadFullHex {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.chkKeys = new System.Windows.Forms.CheckBox();
            this.chkIgnoreCalib = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tltpMain = new System.Windows.Forms.ToolTip(this.components);
            this.txbLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkSigKey = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbKey
            // 
            this.txbKey.AutoCompleteCustomSource.AddRange(new string[] {
            "0x982F626B6A29A1C0"});
            this.txbKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbKey.Enabled = false;
            this.txbKey.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKey.Location = new System.Drawing.Point(12, 58);
            this.txbKey.MaxLength = 18;
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(260, 20);
            this.txbKey.TabIndex = 13;
            this.txbKey.Text = "0xFFFFFFFFFFFFFFFF";
            this.txbKey.TextChanged += new System.EventHandler(this.txbKey_TextChanged);
            // 
            // chkKeys
            // 
            this.chkKeys.AutoSize = true;
            this.chkKeys.Location = new System.Drawing.Point(12, 12);
            this.chkKeys.Name = "chkKeys";
            this.chkKeys.Size = new System.Drawing.Size(108, 17);
            this.chkKeys.TabIndex = 12;
            this.chkKeys.Text = "Use custom key?";
            this.chkKeys.UseVisualStyleBackColor = true;
            this.chkKeys.CheckedChanged += new System.EventHandler(this.chkKeys_CheckedChanged);
            // 
            // chkIgnoreCalib
            // 
            this.chkIgnoreCalib.AutoSize = true;
            this.chkIgnoreCalib.Checked = true;
            this.chkIgnoreCalib.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreCalib.Location = new System.Drawing.Point(12, 84);
            this.chkIgnoreCalib.Name = "chkIgnoreCalib";
            this.chkIgnoreCalib.Size = new System.Drawing.Size(108, 17);
            this.chkIgnoreCalib.TabIndex = 11;
            this.chkIgnoreCalib.Text = "Ignore Calibration";
            this.chkIgnoreCalib.UseVisualStyleBackColor = true;
            this.chkIgnoreCalib.CheckedChanged += new System.EventHandler(this.chkIgnoreCalib_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(116, 177);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Execute";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "txt files|*.txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // tltpMain
            // 
            this.tltpMain.Popup += new System.Windows.Forms.PopupEventHandler(this.tltpMain_Popup);
            // 
            // txbLoc
            // 
            this.txbLoc.Location = new System.Drawing.Point(12, 122);
            this.txbLoc.Multiline = true;
            this.txbLoc.Name = "txbLoc";
            this.txbLoc.ReadOnly = true;
            this.txbLoc.Size = new System.Drawing.Size(233, 23);
            this.txbLoc.TabIndex = 16;
            this.txbLoc.WordWrap = false;
            this.txbLoc.TextChanged += new System.EventHandler(this.txbLoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hex Location:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(248, 122);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(24, 23);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkSigKey
            // 
            this.chkSigKey.AutoSize = true;
            this.chkSigKey.Enabled = false;
            this.chkSigKey.Location = new System.Drawing.Point(12, 35);
            this.chkSigKey.Name = "chkSigKey";
            this.chkSigKey.Size = new System.Drawing.Size(95, 17);
            this.chkSigKey.TabIndex = 17;
            this.chkSigKey.Text = "Use sigfox key";
            this.chkSigKey.UseVisualStyleBackColor = true;
            this.chkSigKey.CheckedChanged += new System.EventHandler(this.chkSigKey_CheckedChanged);
            // 
            // dlgLoadFullHex
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.chkSigKey);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.chkKeys);
            this.Controls.Add(this.chkIgnoreCalib);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txbLoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgLoadFullHex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Full Hex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.CheckBox chkKeys;
        private System.Windows.Forms.CheckBox chkIgnoreCalib;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip tltpMain;
        private System.Windows.Forms.TextBox txbLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chkSigKey;
    }
}