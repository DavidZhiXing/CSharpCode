// define a task engine
//
// should run update every 100ms
// each update should run at least one task step
//
// init the task step at start method, start method should run only once
// raise an event when task step is done in complete method


public class MyTaskEngine : IMyTaskEngine{
        
        public MyTaskEngine(){
            
        }
        
        public void Start(){
            
        }
        
        public void Update(){
            
        }
        
        public void Complete(){
            
        }
        
}

// define a task step

public class MyTaskStep : IMyTaskStep{
        
        public MyTaskStep(){
            
        }
        
        public void Start(){
            
        }
        
        public void Update(){
            
        }
        
        public void Complete(){
            
        }
        
}

// define a task

public class MyTask : IMyTask{
        
        public MyTask(){
            
        }
        
        public void Start(){
            
        }
        
        public void Update(){
            
        }
        
        public void Complete(){
            
        }
        
}

// define a task manager

public class MyTaskManager : IMyTaskManager{
        
        public MyTaskManager(){
            
        }
        
        public void Start(){
            
        }
        
        public void Update(){
            
        }
        
        public void Complete(){
            
        }
        
}

// define 