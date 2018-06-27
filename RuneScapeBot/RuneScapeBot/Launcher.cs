using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace RuneScapeBot
{
    public class Launcher
    {
        private Dictionary<int, string> exitMsg = new Dictionary<int, string>();
        private int exitCode;
        private string Path;
        public Launcher(string path)
        {
           if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("Path is not right");
            }
            exitMsg.Add(0, "Runescape has been closed"); // different exitCodes unknown yet.
            Path = path;
        }

        public void LaunchRuneScape()
        {
            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter the executable to run, including the complete path
            start.FileName = Path;
            // Do you want to show a console window?
            start.WindowStyle = ProcessWindowStyle.Normal;
            start.CreateNoWindow = true;


            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }
        }

        public string GetExitMessage()
        {
            return exitMsg[exitCode];
        }

      
    }
}
