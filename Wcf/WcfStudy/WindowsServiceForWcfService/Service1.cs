using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;

namespace WindowsServiceForWcfService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary.WcfService));
        protected override void OnStart(string[] args)
        {
            host.Open();

        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
