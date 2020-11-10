using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BSP
{
    public partial class BSP : ServiceBase
    {
        public BSP()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        private void bwSrvc_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void pSrvc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            lblSrvc.Text = e.Data;
        }
    }
}
