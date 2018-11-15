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
    public partial class dlgLoadCalib : Form {
        public devIDLog dLog;
        public dlgLoadCalib() {
            InitializeComponent();
            dLog = new devIDLog();
        }

        private void chkKeys_CheckedChanged(object sender, EventArgs e) {
            txbKey.Enabled = chkKeys.Checked;
            chkSigKey.Enabled = chkKeys.Checked;
            chkSigKey.Checked = false;
            txbKey.Text = chkKeys.Checked ? "" : "0xFFFFFFFFFFFFFFFF";  //False key, I need to change it to be able to upload it
            txbKey.Visible = true;
        }
        private void chkSigKey_CheckedChanged(object sender, EventArgs e) {
            txbKey.Visible = !chkSigKey.Checked;
            txbKey.Text = !chkSigKey.Checked ? "" : "0xFFFFFFFFFFFFFFFF";   //False key, I need to change it to be able to upload it
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            if (txbKey.Text.Length < 10) {
                tltpMain.Show("Please ente a key", txbKey);
            }
            else if (txbLoc.Text == "") {
                tltpMain.Show("Please select a file", btnBrowse);
            }
            else {
                if (validateCalibFile(txbLoc.Text) == false) {
                    MessageBox.Show(this, "Invalid calibration file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    cmd c = new cmd();
                    c.type = cmdType.Execute;
                    c.execute.fileName = "axsdb";
                    c.execute.args = "--oldkeys " + txbKey.Text + " --loadcalib " + Program.utils.encloseWithDoubleQuotes(txbLoc.Text);

                    Program.launcherCls.ExecV2(c);
                    if (dLog.Log) Program.LogsForm.appendLog("Unit ID: " + dLog.devID);
                }
            }
        }
        private bool validateCalibFile(string s) {
            return System.IO.File.ReadAllText(s).StartsWith("[MicrofootCal]") ? true : false;
        }
        private void btnBrowse_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                txbLoc.Text = openFileDialog.FileName;
            }
        }
    }
}
