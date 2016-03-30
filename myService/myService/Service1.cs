using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace myService
{
    public partial class Service1 : ServiceBase
    {
        System.Timers.Timer serviceTimer;
        private string fileName;
        public Service1()
        {
            InitializeComponent();
            serviceTimer = new System.Timers.Timer(1000*10);
            serviceTimer.Elapsed += new ElapsedEventHandler(TimerHandler);
        }

        private void TimerHandler(object sender, ElapsedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString();
            File.WriteAllText(fileName, currentTime);
        }

        protected override void OnStart(string[] args)
        {
            fileName = @"C:\tmp\service.log";
            serviceTimer.Start();
        }

        private void OnTimeEvent(object source, ElapsedEventArgs e)
        {
            File.AppendAllText("MyFirstService.log",
                Environment.NewLine+" "+DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
        }

        protected override void OnStop()
        {
        }

    }
}
