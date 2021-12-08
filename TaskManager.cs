// create a class to manage tasks
// can add, remove, and display tasks
// can display tasks in a list or a grid
// can save tasks to a file
// can load tasks from a file
// can save tasks to a database
// can load tasks from a database
// can change current task to a different task
// can change current task to the next task
// can change current task to the previous task
// can change current task to the first task
// can run tasks in a loop
// can run tasks in a loop until a condition is met
// can run task periodically
// can run task parallel

public class TaskManager
{

}

// define a interface for a task
public interface IMyTask
{
    void Run();
    void Stop();
    void Pause();
    void Resume();
    void SetPriority(int priority);
    int GetPriority();
    void SetName(string name);
    string GetName();
    
    void start();

}

// define a class to inherit from IMyTask
public class MyTask : IMyTask
{
    // define a private member to store the task steps
    private List<string> taskSteps = new List<string>();

    //regiseter task steps
    public void RegisterStep(IMyTaskStep step)
    {
        //add step to list
        taskSteps.Add(step);
    }
    public void Run()
    {
        // excute task steps in sequence
        foreach (IMyTaskStep step in taskSteps)
        {
            step.Run();
        }

    }
    public void Stop()
    {
        // stop task
    }
    public void Pause()
    {
        // pause task
    }
    public void Resume()
    {
        // resume task
    }
    public void SetPriority(int priority)
    {
        // set task priority
    }
    public int GetPriority()
    {
        // get task priority
    }
    public void SetName(string name)
    {
        // set task name
    }
    public string GetName()
    {
        // get task name
    }
}




// define a class for a task manager
public class TaskManager
{

}