// create a class to anylize log files
// need read the log in mutiple threads
// need to use a lock to protect the data

public class LogAnalyzer
{
    private IExtensionManager manager;

    public LogAnalyzer(IExtensionManager manager)
    {
        this.manager = manager;
    }

    public int MinNameLength { get; set; }

    public bool IsValidLogFileName(string fileName)
    {
        return manager.IsValid(fileName);
    }

    public int GetNumberOfValidLogFiles()
    {
        int count = 0;
        foreach (var file in Directory.GetFiles(".", "*.SLF"))
        {
            if (IsValidLogFileName(file))
            {
                count++;
            }
        }
        return count;
    }

    public IEnumerable<string> GetListOfValidLogFiles()
    {
        List<string> validFiles = new List<string>();
        foreach (var file in Directory.GetFiles(".", "*.SLF"))
        {
            if (IsValidLogFileName(file))
            {
                validFiles.Add(file);
            }
        }
        return validFiles;
    }

    // read the log file in mutiple threads
    public void Analyze(string fileName)
    {
        var log = new Log(fileName);
        if (log.FileName.Length < MinNameLength)
        {
            throw new Exception("Filename too short: " + log.FileName);
        }

        // read the log file
        // use lock to protect the data
        lock (log)
        {
            log.Open();
            log.Close();
        }
    }
}
