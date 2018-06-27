using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace RuneScapeBot
{
    public class Launcher
    {
        public IntPtr hWnd { get; private set; }
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
            start.WindowStyle = ProcessWindowStyle.Maximized;
            start.CreateNoWindow = true;


            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                // Run the external process & wait for it to finish
                Process proc = Process.Start(start);
                hWnd = proc.MainWindowHandle;
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }).Start();
    }

    public string GetExitMessage()
    {
        return exitMsg[exitCode];
    }


}
}
