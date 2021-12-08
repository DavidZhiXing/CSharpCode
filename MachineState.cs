// create a machine state class
// should have Prepare/Standby/Run/Stop/Restart/Shutdown/Reboot states
// should have a method to change the state
// should have a method to get the current state
// should have a method to get the next state
// should have a method to get the previous state
// should have a method to get the state name
// should have a method to get the state description

public class MachineState
{
    public enum State
    {
        Prepare,
        Standby,
        Run,
        Stop,
        Restart,
        Shutdown,
        Reboot
    }

    private State currentState;

    public MachineState()
    {
        currentState = State.Prepare;
    }

    public void ChangeState(State newState)
    {
        currentState = newState;
    }

    public State GetCurrentState()
    {
        return currentState;
    }

    public State GetNextState()
    {
        State nextState = currentState;
        switch (currentState)
        {
            case State.Prepare:
                nextState = State.Standby;
                break;
            case State.Standby:
                nextState = State.Run;
                break;
            case State.Run:
                nextState = State.Stop;
                break;
            case State.Stop:
                nextState = State.Restart;
                break;
            case State.Restart:
                nextState = State.Shutdown;
                break;
            case State.Shutdown:
                nextState = State.Reboot;
                break;
            case State.Reboot:
                nextState = State.Prepare;
                break;
        }
        return nextState;
    }

    public State GetPreviousState()
    {
        State previousState = currentState;
        switch (currentState)
        {
            case State.Prepare:
                previousState = State.Reboot;
                break;
            case State.Standby:
                previousState = State.Prepare;
                break;
            case State.Run:
                previousState = State.Standby;
                break;
            case State.Stop:
                previousState = State.Run;
                break;
            case State.Restart:
                previousState = State.Stop;
                break;
            case State.Shutdown:
                previousState = State.Restart;
                break;
            case State.Reboot:
                previousState = State.Shutdown;
                break;
        }
        return previousState;
    }

    public string GetStateName()
    {
        string stateName = "";
        switch (currentState)
        {
            case State.Prepare:
                stateName = "Prepare";
                break;
            case State.Standby:
                stateName = "Standby";
                break;
            case State.Run:
                stateName = "Run";
                break;
            case State.Stop:
                stateName = "Stop";
                break;
            case State.Restart:
                stateName = "Restart";
                break;
            case State.Shutdown:
                stateName = "Shutdown";
                break;
            case State.Reboot:
                stateName = "Reboot";
                break;
        }
        return stateName;
    }

    public string GetStateDescription()
    {
        string stateDescription = "";
        switch (currentState)
        {
            case State.Prepare:
                stateDescription = "Prepare the machine for running";
                break;
            case State.Standby:
                stateDescription = "Put the machine in standby mode";
                break;
            case State.Run:
                stateDescription = "Run the machine";
                break;
            case State.Stop:
                stateDescription = "Stop the machine";
                break;
            case State.Restart:
                stateDescription = "Restart the machine";
                break;
            case State.Shutdown:
                stateDescription = "Shutdown the machine";
                break;
            case State.Reboot:
                stateDescription = "Reboot the machine";
                break;
        }
        return stateDescription;
    }

    public override string ToString()
    {
        return GetStateName() + ": " + GetStateDescription();
    }

    public static void Main()
    {
        MachineState machineState = new MachineState();
        Console.WriteLine(machineState);
        machineState.ChangeState(State.Run);
        Console.WriteLine(machineState);
        machineState.ChangeState(State.Stop);
        Console.WriteLine(machineState);
        machineState.ChangeState(State.Restart);
        Console.WriteLine(machineState);
        machineState.ChangeState(State.Shutdown);
        Console.WriteLine(machineState);
        machineState.ChangeState(State.Reboot);
        Console.WriteLine(machineState);
        machineState.ChangeState(State.Prepare);
        Console.WriteLine(machineState);
        machineState.ChangeState(State.Standby);
        Console.WriteLine(machineState);
    }
}
