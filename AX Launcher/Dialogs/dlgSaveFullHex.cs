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
    public partial class dlgSaveFullHex : Form {
        public devIDLog dLog;
        public dlgSaveFullHex() {
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
        private void btnSave_Click(object sender, EventArgs e) {
            if (txbKey.Text.Length < 10) {
                tltpMain.Show("Please enter a key", txbKey);
            }
            else if(txbLoc.Text == "") {
                tltpMain.Show("Please select a location", btnBrowse);
            }
            else {
                cmd c = new cmd();
                c.type = cmdType.Execute;
                c.execute.fileName = "axsdb";
                c.execute.args = " --oldkeys " + txbKey.Text + " --savefullhex " + Program.utils.encloseWithDoubleQuotes(txbLoc.Text);
                //c.delay = 0;
                Program.launcherCls.ExecV2(c);
                if (dLog.Log) Program.LogsForm.appendLog("Unit ID: " + dLog.devID);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                txbLoc.Text = saveFileDialog.FileName;
            }
        }

        
    }
}
