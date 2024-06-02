namespace Multithreading_MasterThreadsAndTasks;
public static class DemoMethods
{
    public static void Method1()
    {
        Console.WriteLine("Method1 Started.");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Method 1 : "+ i);
        }
        Console.WriteLine("Method1 Ended.");
    }

    public static void Method2()
    {
        Console.WriteLine("Method2 Started.");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Method 2 : "+ i);
            if (i==2)
            {
                Console.WriteLine("Executing code Started");
                Thread.Sleep(TimeSpan.FromSeconds(10));
                Console.WriteLine("Executing code ended");
            }
        }
        Console.WriteLine("Method2 Ended.");
    }

    public static void Method3()
    {
        Console.WriteLine("Method3 Started.");
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Method 3 : "+ i);
        }
        Console.WriteLine("Method3 Ended.");
    }
}

