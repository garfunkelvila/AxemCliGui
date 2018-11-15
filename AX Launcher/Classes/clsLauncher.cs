using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create launcher primitive for loop and condition
namespace AX_Launcher {
    public enum resultTypes {
        Pass,
        Fail,
        Neutral //Neutral means just nothing
    }
    public enum cmdType {
        Execute,
        Jump
    }
    public enum jumpTypes {
        Contains
    }

    public class cmdQueue {
        public List<cmd> queue = new List<cmd>();
    }

    public class cmd {
        public cmdType type;
        public execute execute = new execute();
        public jump jump = new jump();
        int  _delay = 100;
        public bool writeLog = true;

        public int delay {
            get {
                return _delay;
            }
            set {
                if (value < 100) {
                    _delay = 100;
                }
                else {
                    _delay = value;
                }
            }
        }
    }

    public class execute {
        string _fileName;
        string _args = "";
        bool _eval = false;
        string[] _FLookup;


        public string fileName {
            get {
                return _fileName;
            }
            set {
                _fileName = value;
            }
        }
        public string args {
            get {
                return _args;
            }
            set {
                _args = value;
            }
        }
        public bool eval {
            get {
                return _eval;
            }
            set {
                _eval = value;
            }
        }
        public string[] FLookup {
            get {
                return _FLookup;
            }
            set {
                _FLookup = new string[value.Length];
                _FLookup = value;
            }
        }
    }
    public class jump {
        jumpTypes _type;
        string _param1;
        string _param2;
        int _jumpTrueTo;
        int _jumpFalseTo;
        public int jumpTrueTo {
            get {
                return _jumpTrueTo;
            }
            set {
                _jumpTrueTo = value;
            }
        }
        public int jumpFalseTo {
            get {
                return _jumpFalseTo;
            }
            set {
                _jumpFalseTo = value;
            }
        }
        public string param1 {
            get {
                return _param1;
            }
            set {
                _param1 = value;
            }
        }
        public string param2 {
            get {
                return _param2;
            }
            set {
                _param2 = value;
            }
        }

        public jumpTypes type {
            get {
                return _type;
            }
            set {
                _type = value;
            }
        }
    }
    /// <summary>
    /// This thing logs whatever it receives from started process
    /// </summary>
    class clsLauncher {
        DateTime startTime;//NOT YET USED, will be used for elapsed time
        DateTime endTime;

        bool _pauseFlag;
        bool _isBusy = false;
        bool _isStopped = false;

        resultTypes _isPassTemp = resultTypes.Neutral;

        System.Diagnostics.Process procMain = new System.Diagnostics.Process();
        System.Windows.Forms.Button _sender = null; // will not be used
        System.Windows.Forms.Timer tmrEnd; // For exit delay
        System.Windows.Forms.Timer tmrExecDelay; // For exit delay

        cmdQueue taskQueue = new cmdQueue();
        int queueIndex = 0; // used by the command to cycle trough commands
        List<string> rValueBuffer = new List<string>(); // might be deleted soon
        
        public delegate void _taskDone(resultTypes e);
        public event _taskDone taskDone;
        
        public clsLauncher() {
            procMain.EnableRaisingEvents = true;
            procMain.StartInfo.CreateNoWindow = true;
            procMain.StartInfo.Domain = "";
            procMain.StartInfo.LoadUserProfile = false;
            procMain.StartInfo.Password = null;
            procMain.StartInfo.RedirectStandardError = true;
            procMain.StartInfo.RedirectStandardInput = true;
            procMain.StartInfo.RedirectStandardOutput = true;
            procMain.StartInfo.StandardErrorEncoding = null;
            procMain.StartInfo.StandardOutputEncoding = null;
            procMain.StartInfo.UserName = "";
            procMain.StartInfo.UseShellExecute = false;
            procMain.SynchronizingObject = Program.LogsForm;
            procMain.Exited += procMain_Exited;
            procMain.OutputDataReceived += procMain_OutputDataReceived;
            procMain.ErrorDataReceived += procMain_ErrorDataReceived;

            tmrEnd = new System.Windows.Forms.Timer();
            tmrEnd.Interval = 1000;
            tmrEnd.Tick += Tmr_End;

            tmrExecDelay = new System.Windows.Forms.Timer();
            tmrExecDelay.Tick += TmrExecDelay_Tick;
        }

        private List<String> lastResult = new List<string>();
        
        #region Timers
        private void Tmr_End(object sender, EventArgs e) {
            //this thing is only called by the procees object..

            tmrEnd.Stop();
            if (taskQueue.queue[queueIndex].type == cmdType.Execute) {
                procMain.CancelErrorRead();
                procMain.CancelOutputRead();
            }
            

            queueIndex++;

            tmrExecDelay.Start(); 

            //tmrEnd.Stop(); //Transfered to top// experiment
            //procExited.Invoke(rValueBuffer);  
        }
        private void TmrExecDelay_Tick(object sender, EventArgs e) {
            tmrExecDelay.Stop();
            //prepare the delay for next command
            if ((queueIndex < taskQueue.queue.Count) && (queueIndex >= 0)) {
                execute(taskQueue.queue[queueIndex]);   //increment is on the Tmr_End
                tmrExecDelay.Interval = taskQueue.queue[queueIndex].delay;
            }
            else {
                Program.LogsForm.updatelblStatus("Done");
                Program.LogsForm.appendLog("********************************************************************************");
                Program.LogsForm.appendLog(_isStopped ? "    Stopped" : "    Done");
                Program.LogsForm.appendLog("********************************************************************************");
                Program.LogsForm.appendLog("");
                Program.LogsForm.appendLog("");
                Console.Beep(2000, 100);
                _isBusy = false;

                if (taskQueue.queue[queueIndex - 1].execute.eval) {
                    _isPassTemp = lastResult.Count == 0 ? resultTypes.Fail : _isPassTemp;
                    _isPassTemp = _isPassTemp != resultTypes.Fail ? resultTypes.Pass : _isPassTemp;
                }

                taskDone.Invoke(_isPassTemp);
            }
        }
        #endregion
        #region Execute codes
        /// <summary>
        /// This one prepares and starts the timer that calls the command queue
        /// TODO: Optional to pass on timer
        /// </summary>
        /// <param name="commands">Container for command queue</param>
        /// <param name="clearLogs">Set to true to clear logs before execute. Usefull and memory safe for endurance tests</param>
        /// <param name="eval">gives return for task done event, else it will just return neutral</param>
        public virtual void ExecV2(cmdQueue commands,bool clearLogs = false, bool eval = false) {
            execPreRoutine();
            if (_isBusy) return;
            taskQueue = commands;
            queueIndex = 0;
            execSubRoutine();
        }

        public virtual void ExecV2(cmd command, bool clearLogs = false, bool eval = false) {
            execPreRoutine();
            if (_isBusy) return;
            taskQueue.queue.Add(command);
            queueIndex = 0;
            execSubRoutine();
        }

        private void execPreRoutine() {
            if (_isBusy == true) {
                System.Windows.Forms.MessageBox.Show("A command is currently running", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            else {
                _isPassTemp = resultTypes.Neutral;
                taskQueue.queue.Clear();
            }
        }
        private void execSubRoutine() {
            lastResult.Clear();
            Program.LogsForm.appendLog("*** STARTED ********************************************************************");
            Program.LogsForm.appendLog(DateTime.Now + "");
            _isStopped = false;
            tmrExecDelay.Start();   //tmrExecDelay is the one that starts the process
        }
        private void execute(cmd command) {
            _isBusy = true;

            switch (command.type) {
                case cmdType.Execute:
                    procMain.StartInfo.FileName = command.execute.fileName;
                    procMain.StartInfo.Arguments = command.execute.args;
                    rValueBuffer.Clear();
                    procMain.Start();

                    if (command.execute.args.Contains("--oldkeys")) {
                        string tmp = "";
                        string[] aa = command.execute.args.Split(' ');

                        aa[Array.IndexOf(aa, "--oldkeys") + 1] = "******************";

                        tmp = string.Join(" ", aa);

                        Program.LogsForm.setLblLastCommand(command.execute.fileName + " " + tmp);
                        Program.LogsForm.appendLog(command.execute.fileName + " " + tmp);
                    }
                    else {
                        Program.LogsForm.setLblLastCommand(command.execute.fileName + " " + command.execute.args);
                        Program.LogsForm.appendLog(command.execute.fileName + " " + command.execute.args);
                    }
                    procMain.BeginOutputReadLine();
                    procMain.BeginErrorReadLine();
                    break;
                case cmdType.Jump:
                    Program.LogsForm.setLblLastCommand("*Jump command*");
                    Program.LogsForm.appendLog("*Jump command*");
                    bool haveMatch = false;
                    switch (command.jump.type) {
                        case jumpTypes.Contains:
                            foreach (string item in lastResult) {
                                if (item.Contains(command.jump.param1)) {
                                    haveMatch = true;
                                }
                            }
                            break;
                        default:
                            break;
                    }

                    if (haveMatch) {
                        queueIndex = command.jump.jumpTrueTo;
                    }
                    else {
                        queueIndex = command.jump.jumpFalseTo;
                    }
                    //tmrEnd.Start();
                    tmrExecDelay.Start();
                    break;
                default:
                    break;
            }
            Program.LogsForm.updatelblStatus("Processing...");
        }
        #endregion
        /// <summary>
        /// Kills the process and clears the command queue
        /// This thing makes the launcher ready for new command
        /// </summary>
        public void Stop() {
            if (isBusy) {
                procMain.Kill();
                //taskQueue.queue.Clear(); //This thiing makes the stopper fail on evaluate, now just make sure it is cleared before starting
                queueIndex = 0;
                _isStopped = true;
                _isBusy = false;
            }
        }
        /// <summary>
        /// This method pauses the queue. If it is called while a process is busy, it will wait that to finish
        /// </summary>
        public void Pause() {
            //
        }

        public void SendCommand(string s) {
            procMain.StandardInput.WriteLine(s);
        }

        #region PRIVATE EVENTS
        private void procMain_Exited(object sender, EventArgs e) {
            //Program.LogsForm.appendLog("*** EXITED *** : this is called by thread, still not right");
            tmrEnd.Start();
        }

        private void procMain_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e) {
            if (e.Data != null) {
                if (taskQueue.queue[queueIndex].execute.FLookup == null) {
                    Program.LogsForm.appendLog(e.Data);
                }
                else {
                    bool hasMatch = false;
                    foreach (string item in taskQueue.queue[queueIndex].execute.FLookup) {
                        if (e.Data.Contains(item)) {
                            hasMatch = true;
                            break;
                        }
                    }


                    if (hasMatch) {
                        Program.LogsForm.appendLog(e.Data + " (FAILED)");
                    }
                    else {
                        Program.LogsForm.appendLog(e.Data);
                    }
                }

                    
                //rValueBuffer.Add(e.Data);
                if (taskQueue.queue[queueIndex].execute.eval) {
                    //means fail
                    // convert to or sooner
                    if ((e.Data.Contains("Addr")) || 
                        (e.Data.Contains("Sigfox Data Signature Invalid"))||
                        (e.Data.Contains("cpustate locked"))) {
                        _isPassTemp = resultTypes.Fail; //Target flip true but not false
                    }
                }
                lastResult.Add(e.Data);
            }
        }
        private void procMain_ErrorDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e) {
            if (e.Data != null) {
                if (taskQueue.queue[queueIndex].execute.FLookup == null) {
                    Program.LogsForm.appendLog(e.Data);
                }
                else {
                    bool hasMatch = false;
                    foreach (string item in taskQueue.queue[queueIndex].execute.FLookup) {
                        if (e.Data.Contains(item)) {
                            hasMatch = true;
                            break;
                        }
                    }


                    if (hasMatch) {
                        Program.LogsForm.appendLog(e.Data + " (FAILED)");
                    }
                    else {
                        Program.LogsForm.appendLog(e.Data);
                    }
                }


                //Program.LogsForm.appendLog("-" + e.Data);
                rValueBuffer.Add(e.Data);
                if (taskQueue.queue[queueIndex].execute.eval) {
                    //means fail
                    // convert to or sooner
                    if ((e.Data.Contains("Addr")) ||
                        (e.Data.Contains("Sigfox Data Signature Invalid")) ||
                        (e.Data.Contains("cpustate locked"))) {
                        _isPassTemp = resultTypes.Fail; //Target flip true but not false
                    }
                }
                lastResult.Add(e.Data);
            }
        }
        #endregion

        #region PROPERTIES
            public bool isBusy {
                get {
                    return _isBusy;
                }
                set {
                _isBusy = value;
                }
            }
        #endregion
    }
}
