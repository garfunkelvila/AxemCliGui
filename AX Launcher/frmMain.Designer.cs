namespace AX_Launcher
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stickLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.autoClearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pingGogolecomtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFwCheck = new System.Windows.Forms.Button();
            this.btnFwVersion = new System.Windows.Forms.Button();
            this.btnBulkErase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.cntxMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.chkVerifyUnitID = new System.Windows.Forms.CheckBox();
            this.txbUnitNumber = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoopTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbFwVersion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFlashProg = new System.Windows.Forms.Button();
            this.btnLoadFullHex = new System.Windows.Forms.Button();
            this.btnLoadCalib = new System.Windows.Forms.Button();
            this.btnSaveFullHex = new System.Windows.Forms.Button();
            this.btnSaveCalib = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOpenCmd = new System.Windows.Forms.Button();
            this.btnShowAxsdbManual = new System.Windows.Forms.Button();
            this.txbHashReturn = new System.Windows.Forms.TextBox();
            this.txbToHash = new System.Windows.Forms.TextBox();
            this.btnCrcCalc = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tmrFwCheckLooper = new System.Windows.Forms.Timer(this.components);
            this.tltpMain = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tltpHints = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.procCmd = new System.Diagnostics.Process();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cntxMain.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsToolStripMenuItem,
            this.stickLogsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.autoClearLogsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Checked = true;
            this.logsToolStripMenuItem.CheckOnClick = true;
            this.logsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // stickLogsToolStripMenuItem
            // 
            this.stickLogsToolStripMenuItem.Checked = true;
            this.stickLogsToolStripMenuItem.CheckOnClick = true;
            this.stickLogsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stickLogsToolStripMenuItem.Name = "stickLogsToolStripMenuItem";
            this.stickLogsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.stickLogsToolStripMenuItem.Text = "Stick logs";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // autoClearLogsToolStripMenuItem
            // 
            this.autoClearLogsToolStripMenuItem.CheckOnClick = true;
            this.autoClearLogsToolStripMenuItem.Enabled = false;
            this.autoClearLogsToolStripMenuItem.Name = "autoClearLogsToolStripMenuItem";
            this.autoClearLogsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.autoClearLogsToolStripMenuItem.Text = "Auto clear logs";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingGogolecomtToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // pingGogolecomtToolStripMenuItem
            // 
            this.pingGogolecomtToolStripMenuItem.Name = "pingGogolecomtToolStripMenuItem";
            this.pingGogolecomtToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pingGogolecomtToolStripMenuItem.Text = "ping gogole.com /t";
            this.pingGogolecomtToolStripMenuItem.Click += new System.EventHandler(this.pingGogolecomtToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnFwCheck
            // 
            this.btnFwCheck.Location = new System.Drawing.Point(127, 105);
            this.btnFwCheck.Name = "btnFwCheck";
            this.btnFwCheck.Size = new System.Drawing.Size(100, 23);
            this.btnFwCheck.TabIndex = 1;
            this.btnFwCheck.Text = "FW Check";
            this.tltpHints.SetToolTip(this.btnFwCheck, "This button is intant");
            this.btnFwCheck.UseVisualStyleBackColor = true;
            this.btnFwCheck.Click += new System.EventHandler(this.btnFwCheck_Click);
            // 
            // btnFwVersion
            // 
            this.btnFwVersion.Location = new System.Drawing.Point(127, 19);
            this.btnFwVersion.Name = "btnFwVersion";
            this.btnFwVersion.Size = new System.Drawing.Size(100, 23);
            this.btnFwVersion.TabIndex = 1;
            this.btnFwVersion.Text = "FW Write";
            this.tltpHints.SetToolTip(this.btnFwVersion, "This button is intant");
            this.btnFwVersion.UseVisualStyleBackColor = true;
            this.btnFwVersion.Click += new System.EventHandler(this.btnFwVersion_Click);
            // 
            // btnBulkErase
            // 
            this.btnBulkErase.Location = new System.Drawing.Point(127, 48);
            this.btnBulkErase.Name = "btnBulkErase";
            this.btnBulkErase.Size = new System.Drawing.Size(100, 23);
            this.btnBulkErase.TabIndex = 1;
            this.btnBulkErase.Text = "Bulk Erase";
            this.tltpHints.SetToolTip(this.btnBulkErase, "This button is intant");
            this.btnBulkErase.UseVisualStyleBackColor = true;
            this.btnBulkErase.Click += new System.EventHandler(this.btnBulkErase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTestResult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFwCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verify";
            // 
            // lblTestResult
            // 
            this.lblTestResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestResult.ContextMenuStrip = this.cntxMain;
            this.lblTestResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestResult.Location = new System.Drawing.Point(6, 16);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(238, 86);
            this.lblTestResult.TabIndex = 9;
            this.lblTestResult.Text = "-- Test Result --";
            this.lblTestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntxMain
            // 
            this.cntxMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.cntxMain.Name = "cntxMain";
            this.cntxMain.Size = new System.Drawing.Size(103, 26);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(233, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*";
            // 
            // chkVerifyUnitID
            // 
            this.chkVerifyUnitID.AutoSize = true;
            this.chkVerifyUnitID.Checked = true;
            this.chkVerifyUnitID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVerifyUnitID.Location = new System.Drawing.Point(12, 32);
            this.chkVerifyUnitID.Name = "chkVerifyUnitID";
            this.chkVerifyUnitID.Size = new System.Drawing.Size(62, 17);
            this.chkVerifyUnitID.TabIndex = 8;
            this.chkVerifyUnitID.Text = "Unit ID:";
            this.chkVerifyUnitID.UseVisualStyleBackColor = true;
            this.chkVerifyUnitID.CheckedChanged += new System.EventHandler(this.chkVerifyUnitID_CheckedChanged);
            // 
            // txbUnitNumber
            // 
            this.txbUnitNumber.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUnitNumber.Location = new System.Drawing.Point(80, 27);
            this.txbUnitNumber.Name = "txbUnitNumber";
            this.txbUnitNumber.Size = new System.Drawing.Size(100, 26);
            this.txbUnitNumber.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.btnLoopTest);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(268, 59);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 134);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Loop Test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Elapsed time: --";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Time started: --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Interval in seconds";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // btnLoopTest
            // 
            this.btnLoopTest.Location = new System.Drawing.Point(144, 105);
            this.btnLoopTest.Name = "btnLoopTest";
            this.btnLoopTest.Size = new System.Drawing.Size(100, 23);
            this.btnLoopTest.TabIndex = 10;
            this.btnLoopTest.Text = "Start";
            this.btnLoopTest.UseVisualStyleBackColor = true;
            this.btnLoopTest.Click += new System.EventHandler(this.btnLoopTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbFwVersion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnFwVersion);
            this.groupBox2.Controls.Add(this.btnFlashProg);
            this.groupBox2.Controls.Add(this.btnLoadFullHex);
            this.groupBox2.Controls.Add(this.btnLoadCalib);
            this.groupBox2.Controls.Add(this.btnBulkErase);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 174);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Write";
            // 
            // txbFwVersion
            // 
            this.txbFwVersion.Location = new System.Drawing.Point(6, 21);
            this.txbFwVersion.Name = "txbFwVersion";
            this.txbFwVersion.Size = new System.Drawing.Size(100, 20);
            this.txbFwVersion.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(233, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "*";
            // 
            // btnFlashProg
            // 
            this.btnFlashProg.Location = new System.Drawing.Point(127, 135);
            this.btnFlashProg.Name = "btnFlashProg";
            this.btnFlashProg.Size = new System.Drawing.Size(100, 23);
            this.btnFlashProg.TabIndex = 1;
            this.btnFlashProg.Text = "Flash Prog";
            this.btnFlashProg.UseVisualStyleBackColor = true;
            this.btnFlashProg.Click += new System.EventHandler(this.btnFlashProg_Click);
            // 
            // btnLoadFullHex
            // 
            this.btnLoadFullHex.Location = new System.Drawing.Point(127, 106);
            this.btnLoadFullHex.Name = "btnLoadFullHex";
            this.btnLoadFullHex.Size = new System.Drawing.Size(100, 23);
            this.btnLoadFullHex.TabIndex = 1;
            this.btnLoadFullHex.Text = "Load Full Hex";
            this.btnLoadFullHex.UseVisualStyleBackColor = true;
            this.btnLoadFullHex.Click += new System.EventHandler(this.btnLoadFullHex_Click);
            // 
            // btnLoadCalib
            // 
            this.btnLoadCalib.Location = new System.Drawing.Point(127, 77);
            this.btnLoadCalib.Name = "btnLoadCalib";
            this.btnLoadCalib.Size = new System.Drawing.Size(100, 23);
            this.btnLoadCalib.TabIndex = 1;
            this.btnLoadCalib.Text = "Load Calib";
            this.btnLoadCalib.UseVisualStyleBackColor = true;
            this.btnLoadCalib.Click += new System.EventHandler(this.btnLoadCalib_Click);
            // 
            // btnSaveFullHex
            // 
            this.btnSaveFullHex.Location = new System.Drawing.Point(144, 106);
            this.btnSaveFullHex.Name = "btnSaveFullHex";
            this.btnSaveFullHex.Size = new System.Drawing.Size(100, 23);
            this.btnSaveFullHex.TabIndex = 2;
            this.btnSaveFullHex.Text = "Save Full Hex";
            this.btnSaveFullHex.UseVisualStyleBackColor = true;
            this.btnSaveFullHex.Click += new System.EventHandler(this.btnSaveFullHex_Click);
            // 
            // btnSaveCalib
            // 
            this.btnSaveCalib.Location = new System.Drawing.Point(144, 77);
            this.btnSaveCalib.Name = "btnSaveCalib";
            this.btnSaveCalib.Size = new System.Drawing.Size(100, 23);
            this.btnSaveCalib.TabIndex = 2;
            this.btnSaveCalib.Text = "Save Calib";
            this.btnSaveCalib.UseVisualStyleBackColor = true;
            this.btnSaveCalib.Click += new System.EventHandler(this.btnSaveCalib_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOpenCmd);
            this.groupBox5.Controls.Add(this.btnShowAxsdbManual);
            this.groupBox5.Controls.Add(this.txbHashReturn);
            this.groupBox5.Controls.Add(this.txbToHash);
            this.groupBox5.Controls.Add(this.btnCrcCalc);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Location = new System.Drawing.Point(12, 379);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(506, 110);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Utilities";
            // 
            // btnOpenCmd
            // 
            this.btnOpenCmd.Location = new System.Drawing.Point(324, 77);
            this.btnOpenCmd.Name = "btnOpenCmd";
            this.btnOpenCmd.Size = new System.Drawing.Size(100, 23);
            this.btnOpenCmd.TabIndex = 3;
            this.btnOpenCmd.Text = "Open AXSDB";
            this.btnOpenCmd.UseVisualStyleBackColor = true;
            this.btnOpenCmd.Click += new System.EventHandler(this.btnOpenCmd_Click);
            // 
            // btnShowAxsdbManual
            // 
            this.btnShowAxsdbManual.Location = new System.Drawing.Point(218, 77);
            this.btnShowAxsdbManual.Name = "btnShowAxsdbManual";
            this.btnShowAxsdbManual.Size = new System.Drawing.Size(100, 23);
            this.btnShowAxsdbManual.TabIndex = 3;
            this.btnShowAxsdbManual.Text = "AXSDB maual";
            this.btnShowAxsdbManual.UseVisualStyleBackColor = true;
            this.btnShowAxsdbManual.Click += new System.EventHandler(this.btnShowAxsdbManual_Click);
            // 
            // txbHashReturn
            // 
            this.txbHashReturn.Enabled = false;
            this.txbHashReturn.Location = new System.Drawing.Point(218, 47);
            this.txbHashReturn.Name = "txbHashReturn";
            this.txbHashReturn.Size = new System.Drawing.Size(100, 20);
            this.txbHashReturn.TabIndex = 2;
            // 
            // txbToHash
            // 
            this.txbToHash.Enabled = false;
            this.txbToHash.Location = new System.Drawing.Point(218, 19);
            this.txbToHash.Name = "txbToHash";
            this.txbToHash.Size = new System.Drawing.Size(206, 20);
            this.txbToHash.TabIndex = 2;
            // 
            // btnCrcCalc
            // 
            this.btnCrcCalc.Enabled = false;
            this.btnCrcCalc.Location = new System.Drawing.Point(324, 44);
            this.btnCrcCalc.Name = "btnCrcCalc";
            this.btnCrcCalc.Size = new System.Drawing.Size(100, 23);
            this.btnCrcCalc.TabIndex = 1;
            this.btnCrcCalc.Text = "CRC Calc";
            this.btnCrcCalc.UseVisualStyleBackColor = true;
            this.btnCrcCalc.Click += new System.EventHandler(this.btnCrcCalc_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(112, 77);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "CPU Status";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(112, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Write to Mem";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(112, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Read Mem";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(6, 77);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Read Mem";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(6, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Disconnect";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text files|*.txt";
            this.saveFileDialog.Title = "Save";
            // 
            // tmrFwCheckLooper
            // 
            this.tmrFwCheckLooper.Interval = 60000;
            // 
            // tltpMain
            // 
            this.tltpMain.IsBalloon = true;
            this.tltpMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltpMain.ToolTipTitle = "Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveFullHex);
            this.groupBox3.Controls.Add(this.btnSaveCalib);
            this.groupBox3.Location = new System.Drawing.Point(268, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 174);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Anything in here wil just be included on log";
            // 
            // tltpHints
            // 
            this.tltpHints.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltpHints.ToolTipTitle = "Hint";
            // 
            // procCmd
            // 
            this.procCmd.EnableRaisingEvents = true;
            this.procCmd.StartInfo.Arguments = "/c axsdb";
            this.procCmd.StartInfo.Domain = "";
            this.procCmd.StartInfo.FileName = "cmd";
            this.procCmd.StartInfo.LoadUserProfile = false;
            this.procCmd.StartInfo.Password = null;
            this.procCmd.StartInfo.RedirectStandardError = true;
            this.procCmd.StartInfo.RedirectStandardInput = true;
            this.procCmd.StartInfo.RedirectStandardOutput = true;
            this.procCmd.StartInfo.StandardErrorEncoding = null;
            this.procCmd.StartInfo.StandardOutputEncoding = null;
            this.procCmd.StartInfo.UserName = "";
            this.procCmd.StartInfo.UseShellExecute = false;
            this.procCmd.SynchronizingObject = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(530, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(59, 17);
            this.lblVersion.Text = "lblVersion";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 528);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chkVerifyUnitID);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txbUnitNumber);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "AXEM OFFLINE DEBUGGER TOOL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Move += new System.EventHandler(this.frmMain_Move);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cntxMain.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.Button btnFwCheck;
        private System.Windows.Forms.Button btnFwVersion;
        private System.Windows.Forms.Button btnBulkErase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadCalib;
        private System.Windows.Forms.Button btnLoadFullHex;
        private System.Windows.Forms.Button btnFlashProg;
        private System.Windows.Forms.Button btnSaveCalib;
        private System.Windows.Forms.Button btnSaveFullHex;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCrcCalc;
        private System.Windows.Forms.TextBox txbHashReturn;
        private System.Windows.Forms.TextBox txbToHash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer tmrFwCheckLooper;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txbUnitNumber;
        private System.Windows.Forms.CheckBox chkVerifyUnitID;
        private System.Windows.Forms.ToolTip tltpMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pingGogolecomtToolStripMenuItem;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.Button btnLoopTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem stickLogsToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbFwVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip tltpHints;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip cntxMain;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button btnShowAxsdbManual;
        private System.Windows.Forms.Button btnOpenCmd;
        private System.Diagnostics.Process procCmd;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripMenuItem autoClearLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

