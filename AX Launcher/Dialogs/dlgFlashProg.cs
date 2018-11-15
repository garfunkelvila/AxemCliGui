using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AX_Launcher.Dialogs {
    public partial class dlgFlashProg : Form {
        public devIDLog dLog;
        public dlgFlashProg() {
            InitializeComponent();
            dLog = new devIDLog();
        }

        private void chkKeys_CheckedChanged(object sender, EventArgs e) {
            txbKey.Enabled = chkKeys.Checked;
            chkSigKey.Enabled = chkKeys.Checked;
            chkSigKey.Checked =false;
            txbKey.Text = chkKeys.Checked ? "" : "0xFFFFFFFFFFFFFFFF";  //False key, I need to change it to be able to upload it
            txbKey.Visible = true;
        }
        private void chkSigKey_CheckedChanged(object sender, EventArgs e) {
            txbKey.Visible = !chkSigKey.Checked;
            txbKey.Text = !chkSigKey.Checked ? "" : "0xFFFFFFFFFFFFFFFF";   //False key, I need to change it to be able to upload it
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            if (txbKey.Text.Length < 10) {
                tltpMain.Show("Please ente a key", txbKey);
            }
            else if (txbLoc.Text == "") {
                tltpMain.Show("Please select a file", btnBrowse);
            }
            else {
                
                    string iC = chkIgnoreCalib.Checked ? "--ignorecalibration " : ""; //Ignore calibration .. this thing need the space after
                    //Program.LogsForm.appendLog("axsdb"+ " --oldkeys " + txbKey.Text + " " + iC + "--flashprog " + openFileDialog.FileName);
                    //Program.launcherCls.Exec("axsdb", "--oldkeys " + txbKey.Text + " " + iC + "--flashprog " + openFileDialog.FileName);
                    cmd c = new cmd();
                    c.type = cmdType.Execute;
                    c.execute.fileName = "axsdb";
                    c.execute.args = "--oldkeys " + txbKey.Text + " " + iC + "--flashprog " + Program.utils.encloseWithDoubleQuotes(txbLoc.Text);

                    Program.launcherCls.ExecV2(c);
                    if (dLog.Log) Program.LogsForm.appendLog("Unit ID: " + dLog.devID);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                txbLoc.Text = openFileDialog.FileName;
            }
        }

        private void txbKey_TextChanged(object sender, EventArgs e) {

        }

        private void chkIgnoreCalib_CheckedChanged(object sender, EventArgs e) {

        }

        private void dlgFlashProg_Load(object sender, EventArgs e) {

        }
    }
}
