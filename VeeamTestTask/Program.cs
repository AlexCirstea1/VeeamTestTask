using VeeamTestTask.FolderSync;

class Program
{
    public static void Main(string[] args)
    {
        FolderSync sync = new FolderSync(
            "C:\\Users\\Alex\\Desktop\\VeeamTestTask\\VeeamTestTask\\DataSource\\",
            "C:\\Users\\Alex\\Desktop\\VeeamTestTask\\VeeamTestTask\\DataReplica\\");

        sync.SynchronizeFolders();
    }
}