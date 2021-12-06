public class FileWatcher
{
    FileSystemWatcher watcher;

    private void Start()
    {
        watcher = new FileSystemWatcher();
        watcher.Path = "c:\\temp";
        // Watch for changes in LastAccess and LastWrite times, and
        // the renaming of files or directories.
        watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
              | NotifyFilters.FileName | NotifyFilters.DirectoryName;
        // only watch for .txt files
        watcher.Filter = "*.txt";
        watcher.Changed += new FileSystemEventHandler(OnChanged);
        watcher.Created += new FileSystemEventHandler(OnChanged);
        watcher.Deleted += new FileSystemEventHandler(OnChanged);
        watcher.Renamed += new RenamedEventHandler(OnRenamed);

        // Begin watching.
        watcher.EnableRaisingEvents = true;
    }

    // Define the event handlers.
    private void OnChanged(object source, FileSystemEventArgs e)
    {
        // Specify what is done when a file is changed, created, or deleted.
        Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
    }

    private void OnRenamed(object source, RenamedEventArgs e)
    {
        // Specify what is done when a file is renamed.
        Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
    }

    private void OnDeleted(object source, FileSystemEventArgs e)
    {
        // Specify what is done when a file is changed, created, or deleted.
        Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
    }

    private void OnCreated(object source, FileSystemEventArgs e)
    {
        // Specify what is done when a file is changed, created, or deleted.
        Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
    }

    private void OnError(object source, ErrorEventArgs e)
    {
        // Specify what is done when the a file or directory cannot be accessed.
        Console.WriteLine("The FileSystemWatcher experienced an error: " + e.GetException().Message);
    }


    // test
    public static void Main()
    {
        FileWatcher fw = new FileWatcher();
        fw.Start();
    }

}