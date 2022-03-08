using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleTest
{
    public partial class WindowsApplicationTest : ServiceBase
    {
        public WindowsApplicationTest()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            File.AppendAllText(@"C:\temp\logForSimpleTest.txt", "service started");
        }

        protected override void OnStop()
        {
            File.AppendAllText(@"C:\temp\logForSimpleTest.txt", "service stopped");
        }
    }
}
