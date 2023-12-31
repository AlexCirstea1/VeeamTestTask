﻿using System;
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
            try
            {
                SynchronizeFolder(sourcePath, replicaPath);
                LogFile("Synchronization completed successfully.");
            }
            catch (Exception e)
            {
                LogFile("Error during synchronization: " + e.Message);
            }
        }

        public void SynchronizeFolder(string sourceFolder, string replicaFolder)
        {
            var sourceFilePaths = Directory.GetFiles(sourceFolder);

            foreach (var sourceFilePath in sourceFilePaths)
            {
                var fileName = Path.GetFileName(sourceFilePath);
                var replicaFilePath = Path.Combine(replicaFolder, fileName);

                try
                {
                    if (File.Exists(replicaFilePath))
                    {
                        var sourceLastModified = File.GetLastWriteTimeUtc(sourceFilePath);
                        var replicaLastModified = File.GetLastWriteTimeUtc(replicaFilePath);

                        if (sourceLastModified > replicaLastModified)
                        {
                            File.Copy(sourceFilePath, replicaFilePath, true);
                            LogFile("File replaced: " + fileName);
                        }
                    }
                    else
                    {
                        File.Copy(sourceFilePath, replicaFilePath);
                        LogFile("File copied: " + fileName);
                    }
                }
                catch (Exception e)
                {
                    LogFile("Error handling file " + fileName + ": " + e.Message);
                }
            }

            foreach (var replicaFilePath in Directory.GetFiles(replicaFolder))
            {
                var fileName = Path.GetFileName(replicaFilePath);

                if (!sourceFilePaths.Contains(Path.Combine(sourceFolder, fileName)))
                {
                    try
                    {
                        File.Delete(replicaFilePath);
                        LogFile("File deleted from replica: " + fileName);
                    }
                    catch (Exception e)
                    {
                        LogFile("Error deleting file from replica: " + fileName + ": " + e.Message);
                    }
                }
            }
        }

        public void LogFile(string message)
        {
            try
            {
                var entry = DateTime.Now + ": " + message;
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
