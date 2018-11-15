namespace AX_Launcher.Dialogs {
    partial class dlgBulkErase {
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.chkKeys = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tltpMain = new System.Windows.Forms.ToolTip(this.components);
            this.chkSigKey = new System.Windows.Forms.CheckBox();
            this.chkIgnoreCalib = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 107);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Method 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(12, 130);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Method 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInformation);
            this.groupBox1.Location = new System.Drawing.Point(121, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblInformation
            // 
            this.lblInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInformation.Location = new System.Drawing.Point(3, 16);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(144, 45);
            this.lblInformation.TabIndex = 0;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(116, 177);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.txbKey.TabIndex = 14;
            this.txbKey.Text = "0xFFFFFFFFFFFFFFFF";
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
            this.chkSigKey.TabIndex = 13;
            this.chkSigKey.Text = "Use sigfox key";
            this.chkSigKey.UseVisualStyleBackColor = true;
            this.chkSigKey.CheckedChanged += new System.EventHandler(this.chkSigKey_CheckedChanged);
            // 
            // chkIgnoreCalib
            // 
            this.chkIgnoreCalib.AutoSize = true;
            this.chkIgnoreCalib.Checked = true;
            this.chkIgnoreCalib.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreCalib.Location = new System.Drawing.Point(12, 84);
            this.chkIgnoreCalib.Name = "chkIgnoreCalib";
            this.chkIgnoreCalib.Size = new System.Drawing.Size(108, 17);
            this.chkIgnoreCalib.TabIndex = 15;
            this.chkIgnoreCalib.Text = "Ignore Calibration";
            this.chkIgnoreCalib.UseVisualStyleBackColor = true;
            // 
            // dlgBulkErase
            // 
            this.AcceptButton = this.btnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.chkIgnoreCalib);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.chkKeys);
            this.Controls.Add(this.chkSigKey);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgBulkErase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bulk Erase";
            this.Load += new System.EventHandler(this.dlgBulkErase_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.CheckBox chkKeys;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip tltpMain;
        private System.Windows.Forms.CheckBox chkSigKey;
        private System.Windows.Forms.CheckBox chkIgnoreCalib;
    }
}