using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeeamTestTask.FolderSync
{
    internal class FolderSync : IFolderSync
    {
        private string sourcePath;
        private string replicaPath;
        private string logPath;

        public FolderSync(string sourcePath, string replicaPath)
        {
            this.sourcePath = sourcePath;
            this.replicaPath = replicaPath;
            LogPathGenerate();
        }

        private void LogPathGenerate()
        {
            string desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logsFilePath = Path.Combine(desktopDirectory, @"VeeamTestTask\VeeamTestTask\Logs\logs.txt");
            logPath = logsFilePath;
        }

        public void SynchronizeFolders()
        {
            try
            {
                LogFile("Synchronization completed successfully.");
            }
            catch (Exception e)
            {
                LogFile("Error during synchronization: " + e.Message);
            }
        }

        public void LogFile(string message)
        {
            try
            {
                string entry = DateTime.Now + ": " + message;
                Console.WriteLine(entry);
                File.AppendAllText(logPath, entry + Environment.NewLine);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error logging: " + e.Message);
            }
        }
    }
}
