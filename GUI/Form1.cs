using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeeamTestTask.FolderSync;

namespace GUI
{
    public partial class Form1 : Form
    {
        private string sourceFolderPath;
        private string replicaFolderPath;
        private string logFilePath;
        private IFolderSync folderSync;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            folderSync = null;
            timer = null;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                var result = folderDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    sourceFolderPath = folderDialog.SelectedPath;
                    sourceFolder.Text = sourceFolderPath;
                }
            }
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                var result = folderDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    replicaFolderPath = folderDialog.SelectedPath;
                    replicaFolder.Text = replicaFolderPath;
                }
            }
        }


        private void logFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Open Log File";

                var result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    logFilePath = openFileDialog.FileName;
                    logFile.Text = logFilePath;
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (folderSync == null)
            {
                // Retrieve source, replica, and log paths from your text boxes or input fields
                string sourcePath = sourceFolderPath;
                string replicaPath = replicaFolderPath;
                string logPath = logFilePath;
                folderSync = new FolderSync(sourcePath, replicaPath, logPath);
                timer = StartPeriodicSync(folderSync);
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }

            if (folderSync != null)
            {
               folderSync = null;
            }
        }

        private Timer StartPeriodicSync(IFolderSync folderSync)
        { 
            int syncInterval = 3000;
            Timer periodicTimer = new Timer();
            periodicTimer.Tick += (sender, e) =>
            {
                folderSync.SynchronizeFolders();
            };
            periodicTimer.Interval = syncInterval;
            periodicTimer.Start();

            return periodicTimer;
        }
    }
}
