using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NMP_Server
{
    public partial class NMP : Form
    {
        //Variables global
        Process nginx = new Process();
        Process php = new Process();
        Process mysql = new Process();

        public NMP()
        {
            InitializeComponent();
        }

        private void browser_Click(object sender, EventArgs e)
        {
            Process browser = new Process();
            browser.StartInfo.FileName = "http://localhost";
            browser.Start();
        }

        private void www_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory + "\\nginx\\www\\");
        }

        private void webServer_Click(object sender, EventArgs e)
        {
            nginx.StartInfo.WorkingDirectory = "nginx"; 
            nginx.StartInfo.FileName = "nginx.exe";
            nginx.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            nginx.Start();
            php.StartInfo.WorkingDirectory = "php"; 
            php.StartInfo.FileName = "php-cgi.exe";
            php.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            php.StartInfo.Arguments = "-b 127.0.0.1:9000";
            php.Start();
            mysql.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\mysql\\bin\\";
            mysql.StartInfo.FileName = "mysqld.exe";
            mysql.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            mysql.Start();

            webServer.Image = Properties.Resources.on;
        }

        private void NMP_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                nginx.Kill();
                php.Kill();
                mysql.Kill();
                foreach (Process proc in Process.GetProcessesByName("nginx"))
                {
                    proc.Kill();
                }
            }
            catch
            {
            }
        }

        private void phpMyAdmin_Click(object sender, EventArgs e)
        {
            Process browser = new Process();
            browser.StartInfo.FileName = "http://localhost/phpmyadmin/index.php";
            browser.Start();
        }
    }
}
