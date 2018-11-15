using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AX_Launcher{
    static class Program{
        public static frmLogs LogsForm;
        //public static System.Diagnostics.Process procMain; //TODO: Transfer to clsLauncher
        public static Classes.clsUtils utils;
        public static clsLauncher launcherCls;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            utils = new Classes.clsUtils();
            LogsForm = new frmLogs();
            //procMain = new System.Diagnostics.Process();
            launcherCls = new clsLauncher();
            Application.Run(new frmMain());
        }
    }
}
