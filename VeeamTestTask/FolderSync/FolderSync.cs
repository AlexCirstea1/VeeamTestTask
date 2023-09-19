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

        public FolderSync(string sourcePath, string replicaPath, string logPath)
        {
            this.sourcePath = sourcePath;
            this.replicaPath = replicaPath;
            this.logPath = logPath;
        }

        public void SynchronizeFolders()
        {
            throw new NotImplementedException();
        }

        public void LogFile(string message)
        {
            throw new NotImplementedException();
        }
    }
}
