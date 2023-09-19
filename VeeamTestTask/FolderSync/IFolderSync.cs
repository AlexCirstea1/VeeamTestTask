using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeeamTestTask.FolderSync
{
    internal interface IFolderSync
    {
        public void SynchronizeFolders();
        public void LogFile(string message);
    }
}
