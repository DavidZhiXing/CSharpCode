// create a container to hold the objects
// IoContainer is a singleton
// IoContainer is a container to hold the objects

public class IoContainer
{
    private static IoContainer _instance;
    private Dictionary<Type, object> _objectMap;

    private IoContainer()
    {
        _objectMap = new Dictionary<Type, object>();
    }

    public static IoContainer Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new IoContainer();
            }
            return _instance;
        }
    }

    public void Register<T>(T obj)
    {
        _objectMap.Add(typeof(T), obj);
    }

    public T Resolve<T>()
    {
        return (T)_objectMap[typeof(T)];
    }
}


public class IoContainerTest
{
    public static void Main()
    {
        IoContainer container = IoContainer.Instance;
        container.Register<IoContainer>(container);
        IoContainer container2 = container.Resolve<IoContainer>();
        Console.WriteLine(container == container2);
    }
}