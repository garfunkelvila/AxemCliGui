using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AX_Launcher {
    public partial class frmMain : Form {
        //bool retarder = true;
        public frmMain() {
            InitializeComponent();
            Program.LogsForm.FormClosing += LogsForm_FormClosing;
            Program.LogsForm.Visible = logsToolStripMenuItem.Checked;
            Program.launcherCls.taskDone += LauncherCls_taskDone;
        }

        private void LauncherCls_taskDone(resultTypes e) {
            // Remove the ID

            switch (e) {
                case resultTypes.Pass:
                    lblTestResult.Text = "Pass";
                    lblTestResult.BackColor = Color.Green;
                    break;
                case resultTypes.Fail:
                    lblTestResult.Text = "Fail";
                    lblTestResult.BackColor = Color.Red;
                    break;
                case resultTypes.Neutral:
                    lblTestResult.BackColor = SystemColors.Control;
                    lblTestResult.Text = "-- Test Result --";
                    break;
                default:
                    break;
            }
            txbUnitNumber.Text = "";
        }

        private void LogsForm_FormClosing(object sender, FormClosingEventArgs e) {
            logsToolStripMenuItem.Checked = false;
        }

        private void frmMain_Load(object sender, EventArgs e) {
            Program.LogsForm.Left = this.Left + this.Width;
            Program.LogsForm.Top = this.Top;

            lblVersion.Text = "v " + Application.ProductVersion + " : build 8-15-2017";
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.LogsForm.Visible = logsToolStripMenuItem.Checked;
            Program.LogsForm.Left = this.Left + this.Width;
            Program.LogsForm.Top = this.Top;
        }


        #region Buttons
        private void btnFwCheck_Click(object sender, EventArgs e) {
            lblTestResult.BackColor = SystemColors.Control;
            lblTestResult.Text = "-- Test Result --";

            if (!checkDevId()) return;

            cmd c = new cmd();
            c.type = cmdType.Execute;
            c.execute.fileName = "axsigfox";
            c.execute.args = "--fwcheck";
            c.execute.FLookup = new string[2] { "Addr" , "Invalid" }; //Currently evaluation is based on eval on launcher
            c.execute.eval = true;
            //c.delay = 0;

            Program.launcherCls.ExecV2(c);
            if (chkVerifyUnitID.Checked) Program.LogsForm.appendLog("Unit ID: " + txbUnitNumber.Text);
        }

        private void btnFwVersion_Click(object sender, EventArgs e) {
            //Dialogs.dlgFwVersion fwVersionDlg = new Dialogs.dlgFwVersion();
            //fwVersionDlg.ShowDialog();
            if (!checkDevId()) return;

            if (txbFwVersion.Text.Length < 5) {
                tltpMain.Show("Please enter the version", txbFwVersion);
            }
            else {
                cmdQueue cq = new cmdQueue();
                cmd c;
                // I am planning to put verify here first before writing
                // then add a feature on  clsLauncher for conditions depending on result
                //c = new cmd();
                //c.type = cmdType.Execute;
                //c.execute.fileName = "axsigfox";
                //c.execute.args = "--fwcheck";
                ////c.delay = 0;
                //cq.queue.Add(c);

                //c = new cmd();
                //c.type = cmdType.Execute;
                //c.execute.fileName = "axsigfox";
                //c.execute.args = "--fwcheck";
                //cq.queue.Add(c);

                //c = new cmd();
                //c.type = cmdType.Jump;
                //c.jump.jumpTrueTo = -1;
                //c.jump.jumpFalseTo = 2;
                //c.jump.type = jumpTypes.Contains;
                //c.jump.param1 = "Sigfox Data Signature Invalid";

                c = new cmd();
                c.type = cmdType.Execute;
                c.execute.fileName = "axsigfox";
                c.execute.args = "--fwversion " + txbFwVersion.Text;
                cq.queue.Add(c);
                
                c = new cmd();
                c.type = cmdType.Execute;
                c.execute.fileName = "axsigfox";
                c.execute.args = "--fwcheck";
                cq.queue.Add(c);

                Program.launcherCls.ExecV2(cq);
                if (chkVerifyUnitID.Checked) Program.LogsForm.appendLog("Unit ID: " + txbUnitNumber.Text);
            }
        }

        private void btnCrcCalc_Click(object sender, EventArgs e) {
            Classes.clsCrcConvert crck = new Classes.clsCrcConvert();
            txbHashReturn.Text = txbToHash.Text.GetHashCode() + ""; //Not this
        }

        private void btnSaveFullHex_Click(object sender, EventArgs e) {
            if (!checkDevId()) return;
            Dialogs.dlgSaveFullHex saveFullHexDlg = new Dialogs.dlgSaveFullHex();
            saveFullHexDlg.dLog.devID = txbUnitNumber.Text;
            saveFullHexDlg.dLog.Log = chkVerifyUnitID.Checked;
            saveFullHexDlg.ShowDialog();
        }

        private void btnFlashProg_Click(object sender, EventArgs e) {
            if (!checkDevId()) return;
            Dialogs.dlgFlashProg flashProgDlg = new Dialogs.dlgFlashProg();
            flashProgDlg.dLog.devID = txbUnitNumber.Text;
            flashProgDlg.dLog.Log = chkVerifyUnitID.Checked;
            flashProgDlg.ShowDialog();
        }

        private void btnSaveCalib_Click(object sender, EventArgs e) {
            if (!checkDevId()) return;
            Dialogs.dlgSaveCalib saveCalibDialog = new Dialogs.dlgSaveCalib();
            saveCalibDialog.dLog.devID = txbUnitNumber.Text;
            saveCalibDialog.dLog.Log = chkVerifyUnitID.Checked;
            saveCalibDialog.ShowDialog();
        }

        private void btnLoadCalib_Click(object sender, EventArgs e) {
            if (!checkDevId()) return;
            Dialogs.dlgLoadCalib loadCalibDlg = new Dialogs.dlgLoadCalib();
            loadCalibDlg.dLog.devID = txbUnitNumber.Text;
            loadCalibDlg.dLog.Log = chkVerifyUnitID.Checked;
            loadCalibDlg.ShowDialog();
        }
        #endregion
        private void pingGogolecomtToolStripMenuItem_Click(object sender, EventArgs e) {
            cmd c = new cmd();
            c.type = cmdType.Execute;
            c.execute.fileName = "ping";
            c.execute.args = "google.com /t";
            //c.delay = 0;

            Program.launcherCls.ExecV2(c);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (Program.launcherCls.isBusy) {
                e.Cancel = true;
                MessageBox.Show(this, "cant exit now, the process is still busy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkVerifyUnitID_CheckedChanged(object sender, EventArgs e) {
            txbUnitNumber.Enabled = chkVerifyUnitID.Checked;
            //txbUnitNumber.Text
        }
        private void frmMain_Move(object sender, EventArgs e) {
            if (stickLogsToolStripMenuItem.Checked) {
                Program.LogsForm.Left = this.Left + this.Width;
                Program.LogsForm.Top = this.Top;
            }
        }

        private bool checkDevId() {
            if ((chkVerifyUnitID.Checked && txbUnitNumber.TextLength > 0) || (!chkVerifyUnitID.Checked)) {
                return true;
            }
            else {
                tltpMain.Show("Please enter the unit ID", txbUnitNumber);
                tltpMain.Show("Please enter the unit ID", txbUnitNumber);
                return false;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
            lblTestResult.BackColor = SystemColors.Control;
            lblTestResult.Text = "-- Test Result --";
        }

        private void btnLoadFullHex_Click(object sender, EventArgs e) {
            if (!checkDevId()) return;
            Dialogs.dlgLoadFullHex loadFullHexDialog = new Dialogs.dlgLoadFullHex();
            loadFullHexDialog.dLog.devID = txbUnitNumber.Text;
            loadFullHexDialog.dLog.Log = chkVerifyUnitID.Checked;
            loadFullHexDialog.ShowDialog();
        }

        private void btnLoopTest_Click(object sender, EventArgs e) {
            cmdQueue cq = new cmdQueue(); ;
            cmd c;

            c = new cmd();
            c.type = cmdType.Execute;
            c.execute.fileName = "axsigfox";
            c.execute.args = "--fwcheck";
            cq.queue.Add(c);

            c = new cmd();
            c.type = cmdType.Jump;
            c.jump.type = jumpTypes.Contains;
            c.jump.param1 = "Addr ";
            c.jump.jumpTrueTo = -1; //stop for flipped bit
            c.jump.jumpFalseTo = 0; //repeat if not detected
            cq.queue.Add(c);

            Program.launcherCls.ExecV2(cq, true);
        }
         

        private void btnBulkErase_Click(object sender, EventArgs e) {
            if (!checkDevId()) return;
            Dialogs.dlgBulkErase bulkErase = new Dialogs.dlgBulkErase();
            bulkErase.dLog.devID = txbUnitNumber.Text;
            bulkErase.dLog.Log = chkVerifyUnitID.Checked;
            bulkErase.ShowDialog();
        }

        private void btnShowAxsdbManual_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\AXSEM\\AXSDB\\AX8052Debugger.pdf");
        }

        private void btnOpenCmd_Click(object sender, EventArgs e) {
            cmd c;

            c = new cmd();
            c.type = cmdType.Execute;
            c.execute.fileName = "axsdb";

            Program.launcherCls.ExecV2(c, true);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            Forms.frmAbout AboutFrm = new Forms.frmAbout();
            AboutFrm.ShowDialog();
        }
    }

    public class devIDLog {
        public string devID;
        public bool Log;
    }
}
