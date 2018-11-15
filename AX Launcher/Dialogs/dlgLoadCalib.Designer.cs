namespace AX_Launcher.Dialogs {
    partial class dlgLoadCalib {
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tltpMain = new System.Windows.Forms.ToolTip(this.components);
            this.chkSigKey = new System.Windows.Forms.CheckBox();
            this.txbLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
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
            this.txbKey.TabIndex = 22;
            this.txbKey.Text = "0xFFFFFFFFFFFFFFFF";
            // 
            // chkKeys
            // 
            this.chkKeys.AutoSize = true;
            this.chkKeys.Location = new System.Drawing.Point(12, 12);
            this.chkKeys.Name = "chkKeys";
            this.chkKeys.Size = new System.Drawing.Size(108, 17);
            this.chkKeys.TabIndex = 21;
            this.chkKeys.Text = "Use custom key?";
            this.chkKeys.UseVisualStyleBackColor = true;
            this.chkKeys.CheckedChanged += new System.EventHandler(this.chkKeys_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(116, 176);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "Execute";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "txt files|*.txt";
            // 
            // chkSigKey
            // 
            this.chkSigKey.AutoSize = true;
            this.chkSigKey.Enabled = false;
            this.chkSigKey.Location = new System.Drawing.Point(12, 35);
            this.chkSigKey.Name = "chkSigKey";
            this.chkSigKey.Size = new System.Drawing.Size(95, 17);
            this.chkSigKey.TabIndex = 26;
            this.chkSigKey.Text = "Use sigfox key";
            this.chkSigKey.UseVisualStyleBackColor = true;
            this.chkSigKey.CheckedChanged += new System.EventHandler(this.chkSigKey_CheckedChanged);
            // 
            // txbLoc
            // 
            this.txbLoc.Location = new System.Drawing.Point(12, 95);
            this.txbLoc.Multiline = true;
            this.txbLoc.Name = "txbLoc";
            this.txbLoc.ReadOnly = true;
            this.txbLoc.Size = new System.Drawing.Size(233, 23);
            this.txbLoc.TabIndex = 25;
            this.txbLoc.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Calib Location:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(248, 95);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(24, 23);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dlgLoadCalib
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.chkKeys);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.chkSigKey);
            this.Controls.Add(this.txbLoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgLoadCalib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Calib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.CheckBox chkKeys;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip tltpMain;
        private System.Windows.Forms.CheckBox chkSigKey;
        private System.Windows.Forms.TextBox txbLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
    }
}