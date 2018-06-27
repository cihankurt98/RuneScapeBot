using System;
using System.Windows.Forms;


namespace RuneScapeBot
{
    public partial class Form1 : Form
    {
        Launcher launcher;
        public Form1()
        {
            InitializeComponent();
            btn_launch.Enabled = false;
        }

        private void btn_launch_Click(object sender, EventArgs e)
        {
            launcher.LaunchRuneScape();
            MessageBox.Show(launcher.GetExitMessage());
        }


        private void btn_selectFile_Click(object sender, EventArgs e)
        {
            string path = GetPath();

            if (string.IsNullOrWhiteSpace(path))
            {
                return; //nothing selected do nothing.
            }

            try
            {
                launcher = new Launcher(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Path is not good. Select it again.");
            }
            finally
            {
                btn_launch.Enabled = true;
            }

        }

        private string GetPath()
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Applications (*.exe)|*.exe";
            fileDialog.ShowDialog();
            return fileDialog.FileName;
        }
    }
}
