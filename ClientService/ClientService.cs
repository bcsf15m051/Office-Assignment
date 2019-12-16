using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Configuration.Install;
using System.ServiceModel;


namespace ClientService
{
    public partial class ClientService : ServiceBase
    {
        private static FileSystemWatcher watcher = new FileSystemWatcher();
        private static string applicationPath = null;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public ClientService()
        {
            InitializeComponent();
           //this.OnStart(null);
        }

        protected override void OnStart(string[] arges)
        {
            try
            {
                applicationPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + "\\myFile.txt";
                watcher.Path = Path.GetDirectoryName(applicationPath);
                watcher.Filter = Path.GetFileName(applicationPath);
                log.Info("path: " + applicationPath);
                //watcher.Path = @"C:\Users\maida.tayyab\source\repos\EncyptAndUploadFiles\EncyptAndUploadFiles\bin\Debug";
                //watcher.Filter = @"C:\Users\maida.tayyab\source\repos\EncyptAndUploadFiles\EncyptAndUploadFiles\bin\Debug\myFile.txt";
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;
                watcher.Changed += OnChanged;
            }
            catch(Exception ex)
            {
                log.Info(ex.Message);
     
            }
            finally
            {
          
            }
        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            log.Info("Onchange method called");
            using (StreamWriter sw = new StreamWriter(@"C:\Users\maida.tayyab\source\repos\EncyptAndUploadFiles\EncyptAndUploadFiles\bin\Debug\myFile.txt", true))
            {
                sw.WriteLine("\n Hello from service");
            }
            //using (StreamReader theReader = new StreamReader(applicationPath))
            //{
            //    string CurrentLine = "";
            //    Process proces = new Process();
            //    while ((CurrentLine = theReader.ReadLine()) != null)
            //    {
            //        string[] line = CurrentLine.Split(':');
            //        if(line[0].Equals("path"))
            //        {
            //             proces.Path = line[1];
            //        }
            //        else if (line[0].Equals("port"))
            //        {
            //            proces.Port = line[1];
            //        }
            //        else if (line[0].Equals("Ip"))
            //        {
            //            proces.Ip = line[1];
            //        }
            //         if(DBManipulator.GetDBManipulator().CheckPath(proces.Path) > 0)
            //        {
            //            //
            //        }
            //    }
            //}
        }
  
        protected override void OnStop()
        {
            
        }
    }
}
