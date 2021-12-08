// create a set of classes that implement a singleton pattern
//

public class Singleton
{
    private static Singleton instance = null;
    private static readonly object padlock = new object();

    public static Singleton Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

    private Singleton()
    {
    }
}

public class client
{
    public static void Main()
    {
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;

        if (s1 == s2)
        {
            Console.WriteLine("Objects are the same instance");
        }
    }
}