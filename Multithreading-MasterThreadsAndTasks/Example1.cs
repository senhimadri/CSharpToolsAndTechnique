namespace Multithreading_MasterThreadsAndTasks;

public class Example1
{
    public void Execution()
    {
        Task task = new(() =>
        {
            Console.WriteLine("Running task in seperate thread:::::::::::::::::");
            int result = AddNumber(5, 8);
            Console.WriteLine($"Result of Addition {result} :::::::::::::::::::::::::::");
        });

        task.Start();

        Console.WriteLine("Main thread is done:::::::::::::::::::::::::::::::::::::");

        Console.ReadLine();
        int AddNumber(int a, int b)
        {
            return a + b;
        }
    }
}

