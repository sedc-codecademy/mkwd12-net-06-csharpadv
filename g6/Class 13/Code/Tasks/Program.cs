//this code belongs to the inital thread
Console.WriteLine("Hello");

//create task, no result -> void
Task firstTask = new Task(() =>
{
    Console.WriteLine("Hello from first task");
});

//give this task to a free thread from the thread pool
firstTask.Start();

//task that returns a value - int
Task<int> secondTask = new Task<int>(() =>
{
   // Thread.Sleep(1000); //it will sleep (stop) the thread on which this task is executed
    Console.WriteLine("Returning a value");
    return 10;
});

//give this task to a free thread from the thread pool
secondTask.Start();

//create and start in the same line
Task.Run(() => {
    //Thread.Sleep(1000); //it will sleep (stop) the thread on which this task is executed
    Console.WriteLine("Code that executes immediatelly");
});


for( int i = 0; i < 20; i++)
{
    int temp = i;
    Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine(temp);
    });
} 

//we need this because sometimes the main thread on which program.cs is executing finishes before the other threads on which the tasks are executing
//this way we don't let the app to finish
Console.ReadLine(); 