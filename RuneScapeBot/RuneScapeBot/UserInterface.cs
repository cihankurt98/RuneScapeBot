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

namespace RuneScapeBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_launch_Click(object sender, EventArgs e)
        { 

            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter the executable to run, including the complete path
            start.FileName = @"C:\Users\Cihan\Downloads\OSBuddy64.exe";
            // Do you want to show a console window?
            start.WindowStyle = ProcessWindowStyle.Normal;
            start.CreateNoWindow = true;
            int exitCode;


            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
                MessageBox.Show("Runescape has been quit" + exitCode);
            }
        }
    }
}
