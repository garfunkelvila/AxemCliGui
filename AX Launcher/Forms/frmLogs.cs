using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AX_Launcher{
    public partial class frmLogs : Form{
        string currentDir = ""; //For ctrl+s action
        bool isSaved = true;
        public frmLogs(){
            InitializeComponent();
        }

        private void frmLogs_Load(object sender, EventArgs e) {

        }
        public void appendLog(string log) {
            txbLogs.AppendText(log + Environment.NewLine);
        }
        public void updatelblStatus(string s) {
            lblStatus.Text = s;
        }

        public void setLblLastCommand(string str) {
            lblLastCommand.Text = "Last command: " + str;
        }

        private void txbLogs_TextChanged(object sender, EventArgs e) {
            if (!isSaved) return;
            isSaved = false;
            if (!this.Text.Contains("*")) {
                this.Text += "*";
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txbLogs.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e) {
            saveRoutine();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            saveRoutine();
        }

        private void saveRoutine() {
            if (currentDir == ""){
                //Ask for save
                if (saveFileDialogMain.ShowDialog() == DialogResult.OK) {
                    System.IO.StreamWriter txt = new System.IO.StreamWriter(saveFileDialogMain.FileName);
                    txt.WriteLine(txbLogs.Text);
                    txt.Close();
                    this.Text = "Logs - " + saveFileDialogMain.FileName;
                    currentDir = saveFileDialogMain.FileName;
                    //saveFileDialogMain.se
                    txt.Dispose();
                    isSaved = true;
                }
            }
            else {
                System.IO.StreamWriter txt = new System.IO.StreamWriter(currentDir);
                txt.WriteLine(txbLogs.Text);
                txt.Close();
                txt.Dispose();
                isSaved = true;
                this.Text = "Logs - " + saveFileDialogMain.FileName;
            }
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            if (isSaved) {
                currentDir = "";
                this.Text = "Logs - New";
                txbLogs.Text = "";
                isSaved = false;
            }
            else {
                DialogResult dr = MessageBox.Show(this,"Do you want to save the logs before creating a new one?","Are you sure?",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dr) {
                    case DialogResult.Yes:
                        saveRoutine();
                        break;
                    case DialogResult.No:
                        currentDir = "";
                        this.Text = "Logs - New";
                        txbLogs.Text = "";
                        isSaved = false;
                        break;
                    default:
                        //just do nothing
                        break;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e) {
            Program.launcherCls.Stop();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmLogs_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK) {
                System.IO.StreamWriter txt = new System.IO.StreamWriter(saveFileDialogMain.FileName);
                txt.WriteLine(txbLogs.Text);
                txt.Close();
                this.Text = "Logs - " + saveFileDialogMain.FileName;
                currentDir = saveFileDialogMain.FileName;
                //saveFileDialogMain.se
                txt.Dispose();
                isSaved = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e) {
            if (Program.launcherCls.isBusy) { 
                Program.launcherCls.SendCommand(txbCmdInterupt.Text);
                appendLog(">>" + txbCmdInterupt.Text);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            //saveRoutine();
            openFileDialogMain.FileName = "";
            if (openFileDialogMain.ShowDialog() == DialogResult.OK) {
                txbLogs.Text = System.IO.File.ReadAllText(openFileDialogMain.FileName);
                currentDir = openFileDialogMain.FileName;
                this.Text = "Logs - " + openFileDialogMain.FileName;
                isSaved = true;
            }
            
        }
    }
}
