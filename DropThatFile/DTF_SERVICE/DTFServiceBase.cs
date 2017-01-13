using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DTF_SERVICE
{
    public partial class DTFServiceBase : ServiceBase
    {
        private EventLog logs;

        public DTFServiceBase()
        {
            InitializeComponent();
            logs = new EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            logs.Source = "MySource";
            logs.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
