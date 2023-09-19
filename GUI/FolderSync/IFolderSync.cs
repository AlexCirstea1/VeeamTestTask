using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeeamTestTask.FolderSync
{
    internal interface IFolderSync
    { 
        void SynchronizeFolders();
        void SynchronizeFolder(string sourceFolder, string replicaFolder);
        void LogFile(string message);
    }
}
