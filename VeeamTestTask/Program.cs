using VeeamTestTask.FolderSync;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Folder Synchronization:\nEnter Source Folder Path:");
        var sourcePath = Console.ReadLine();
        Console.WriteLine("Enter Replica Folder Path:");
        var replicaPath = Console.ReadLine();
        Console.WriteLine("Enter Log File Path:");
        var logPath = Console.ReadLine();

        IFolderSync folderSync = new FolderSync(sourcePath, replicaPath, logPath);

        PeriodicSync(folderSync);

        Console.WriteLine("Press 'Q' to quit.");
        while (Console.ReadKey().Key != ConsoleKey.Q);
    }

    public static void PeriodicSync(IFolderSync folderSync)
    {
        Console.WriteLine("Enter synchronization interval:");
        var syncInterval = int.Parse(Console.ReadLine());
        var timer = new Timer(
            state => folderSync.SynchronizeFolders(),
            null, 
            0, 
            syncInterval);
    }
}