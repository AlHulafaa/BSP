namespace BSP
{
    partial class BSP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.evtLogSrvc = new System.Diagnostics.EventLog();
            this.bwSrvc = new System.ComponentModel.BackgroundWorker();
            this.pbSrvc = new System.Windows.Forms.ProgressBar();
            this.pSrvc = new System.Diagnostics.Process();
            this.lblSrvc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.evtLogSrvc)).BeginInit();
            // 
            // evtLogSrvc
            // 
            this.evtLogSrvc.EnableRaisingEvents = true;
            this.evtLogSrvc.Log = "BSP";
            this.evtLogSrvc.Source = "BSP";
            // 
            // bwSrvc
            // 
            this.bwSrvc.WorkerReportsProgress = true;
            this.bwSrvc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSrvc_DoWork);
            // 
            // pbSrvc
            // 
            this.pbSrvc.Location = new System.Drawing.Point(0, 0);
            this.pbSrvc.MarqueeAnimationSpeed = 10;
            this.pbSrvc.Name = "pbSrvc";
            this.pbSrvc.Size = new System.Drawing.Size(100, 23);
            this.pbSrvc.Step = 1;
            this.pbSrvc.TabIndex = 0;
            // 
            // pSrvc
            // 
            this.pSrvc.EnableRaisingEvents = true;
            this.pSrvc.StartInfo.Domain = "";
            this.pSrvc.StartInfo.LoadUserProfile = false;
            this.pSrvc.StartInfo.Password = null;
            this.pSrvc.StartInfo.StandardErrorEncoding = null;
            this.pSrvc.StartInfo.StandardOutputEncoding = null;
            this.pSrvc.StartInfo.UserName = "";
            this.pSrvc.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.pSrvc_OutputDataReceived);
            // 
            // lblSrvc
            // 
            this.lblSrvc.AutoSize = true;
            this.lblSrvc.Location = new System.Drawing.Point(0, 0);
            this.lblSrvc.Name = "lblSrvc";
            this.lblSrvc.Size = new System.Drawing.Size(100, 23);
            this.lblSrvc.TabIndex = 0;
            this.lblSrvc.Text = "label1";
            // 
            // BSP
            // 
            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            this.ServiceName = "BSP";
            ((System.ComponentModel.ISupportInitialize)(this.evtLogSrvc)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog evtLogSrvc;
        private System.ComponentModel.BackgroundWorker bwSrvc;
        public System.Windows.Forms.ProgressBar pbSrvc;
        private System.Diagnostics.Process pSrvc;
        private System.Windows.Forms.Label lblSrvc;
    }
}
