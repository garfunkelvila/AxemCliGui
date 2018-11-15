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
    public partial class dlgBulkErase : Form {
        public devIDLog dLog;
        public dlgBulkErase() {
            InitializeComponent();
            dLog = new devIDLog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            lblInformation.Text = "This one fills with FF";
        }

        private void dlgBulkErase_Load(object sender, EventArgs e) {
            radioButton1.Checked = true;
        }

        private void btnExecute_Click(object sender, EventArgs e) {
            //MessageBox.Show(Application.StartupPath + "\\Resources\\bulkerase.txt");
            if (txbKey.Text.Length < 10) {
                tltpMain.Show("Please ente a key", txbKey);
            }
            else {

                string iC = chkIgnoreCalib.Checked ? "--ignorecalibration " : "";

                cmd c = new cmd();
                c.type = cmdType.Execute;
                c.execute.fileName = "axsdb";
                c.writeLog = false;
                c.execute.args = "--oldkeys " + txbKey.Text + " " + iC + "--flashprog " + Program.utils.encloseWithDoubleQuotes(Application.StartupPath + "\\Resources\\bulkerase.txt");
                c.execute.FLookup = new string[1] { "no target interface connected" };

                Program.launcherCls.ExecV2(c);
                if (dLog.Log) Program.LogsForm.appendLog("Unit ID: " + dLog.devID);
                
            }
        }

        private void chkKeys_CheckedChanged(object sender, EventArgs e) {
            txbKey.Enabled = chkKeys.Checked;
            chkSigKey.Enabled = chkKeys.Checked;
            chkSigKey.Checked = false;
            txbKey.Text = chkKeys.Checked ? "" : "0xFFFFFFFFFFFFFFFF"; //False key, I need to change it to be able to upload it
            txbKey.Visible = true;
        }
        private void chkSigKey_CheckedChanged(object sender, EventArgs e) {
            txbKey.Visible = !chkSigKey.Checked;
            txbKey.Text = !chkSigKey.Checked ? "" : "0xFFFFFFFFFFFFFFFF"; //False key, I need to change it to be able to upload it
        }
    }
}
