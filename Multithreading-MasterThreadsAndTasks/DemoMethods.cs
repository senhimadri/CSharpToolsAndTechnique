﻿namespace Multithreading_MasterThreadsAndTasks;

public delegate void SumOfCallBackVoid(int SumofNum);

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

    public static void ShowNumber()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void ShowNumber(int MaxValue)
    {
        for (int i = 0; i <= MaxValue; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static object _lock = new object();
    public static void WriteContex()
    {
        Monitor.Enter(_lock);

        for (int i = 0; i < 5; i++)
        {
            Monitor.Pulse(_lock);
            Console.WriteLine($"Write Started {i}");
            Console.WriteLine($"Write Ended {i}");
            Monitor.Wait(_lock);
        }

        Monitor.Exit(_lock);

    }

    public static void ReadContex()
    {
        Monitor.Enter(_lock);
        for (int i = 0; i < 5; i++)
        {
            Monitor.Pulse(_lock);
            Console.WriteLine($"Read Started {i}");
            Console.WriteLine($"Read Ended {i}");
            Monitor.Wait(_lock);
        }

        Monitor.Exit(_lock);
    }

}


public class NumberHelper
{
    private readonly int _number;
    public NumberHelper(int number) => _number= number;

    public void ShowNumber()
    {
        for (int i = 0; i <= _number; i++)
        {
            Console.WriteLine(i);
        }
    }

}

public class NumberHelperWithCallBack
{
    private readonly int _number;
    private SumOfCallBackVoid _callbackDelegate;


    public NumberHelperWithCallBack(int number, SumOfCallBackVoid callbackDelegate)
                    => (_number, _callbackDelegate)=(number, callbackDelegate);

    public void ShowNumbers()
    {
        int sum = 0;

        for (int i = 0; i <= _number; i++)
        {
            sum+= i;
        }

        if (_callbackDelegate != null)
            _callbackDelegate(sum);
    }

}






