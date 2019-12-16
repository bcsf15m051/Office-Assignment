using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncyptAndUploadFiles
{
    public partial class Form1 : Form
    {
        private static ServiceController sc = new ServiceController("ClientService");
        public Form1()
        {
            InitializeComponent();
            sc = new ServiceController("ClientService");
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtboxDirectoryPath.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void btnStartEncrypting_Click(object sender, EventArgs e)
        {
            if(!sc.Status.Equals(ServiceControllerStatus.Running))
            {
                MessageBox.Show("Service is not running, kindly start the Service first.");
                return;
            }
            validateFields();
            string port = txtBoxIP.Text.Trim();
            string ip = txtBoxPort.Text.Trim();
            string path = txtboxDirectoryPath.Text.Trim();
            string format = Format.Checked ? Format.Text : Format2.Text;
                using (var tw = new StreamWriter("myFile.txt", true))
                {
                    tw.WriteLine("process:"+ DateTime.Now.ToString());
                    tw.WriteLine("path:" + path);
                    tw.WriteLine("Ip:"+ip);
                    tw.WriteLine("port:"+port);
                    tw.WriteLine("format:" + format);
                    tw.WriteLine("process:"+DateTime.Now.ToString());
            }
        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
                sc.Stop();
                btnStartService.Enabled = true;
                btnStopService.Enabled = false;
        }

        private void btnStartService_Click(object sender, EventArgs e)
        {   
        if (!sc.Status.Equals(ServiceControllerStatus.Running))
        {
                sc.Start();
                btnStartService.Enabled = false;
                btnStopService.Enabled = true;
        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             sc = new ServiceController("ClientService");
            if (sc.Status.Equals(ServiceControllerStatus.Running))
            {
                btnStartService.Enabled = false;
            }
            else
            {
                btnStopService.Enabled = false;
            }
            Format.Text = "md5";
            Format2.Text = "SHA ";
        }
        private void validateFields()
        {
            if(string.IsNullOrWhiteSpace(txtBoxIP.Text.Trim()))
            {
                MessageBox.Show("Enter the IP address");
                txtBoxIP.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxPort.Text.Trim()))
            {
                MessageBox.Show("Enter the Port address");
                txtBoxPort.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtboxDirectoryPath.Text.Trim()))
            {
                MessageBox.Show("Enter the directory path");
                txtboxDirectoryPath.Focus();
                return;
            }
            if (!(Format.Checked || Format2.Checked))
            {
                MessageBox.Show("Select Encryption Format");
                Format.Focus();
                return;
            } 
        }
    }
}
