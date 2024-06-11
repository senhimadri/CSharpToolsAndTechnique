using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Multithreading_MasterThreadsAndTasks;

public class ThreadExecution
{
    public void SingleThreadExecution()
    {
        DemoMethods.Method1();
        Console.WriteLine("Method 1 Execution is completed");
        DemoMethods.Method2();
        Console.WriteLine("Method 2 Execution is completed");
        DemoMethods.Method3();
        Console.WriteLine("Method 3 Execution is completed");
    }
    public void MultiThreadExecution()
    {
        Console.WriteLine("Main Thread Started");

        Thread T1 = new Thread(DemoMethods.Method1)
        {
            Name = "Thread1"
        };

        Thread T2 = new Thread(DemoMethods.Method2)
        {
            Name = "Thread2"
        };

        Thread T3 = new Thread(DemoMethods.Method3)
        {
            Name = "Thread3"
        };

        T1.Start();
        T2.Start();
        T3.Start();

        Console.WriteLine("Main Thread Ended");
    }
    public void ConstructorsOfThread()
    {
        //ThreadStart obj = new ThreadStart(DemoMethods.ShowNumber);
        //ThreadStart obj = DemoMethods.ShowNumber;
        //ThreadStart obj = delegate () { DemoMethods.ShowNumber(); };

        ThreadStart obj = () => DemoMethods.ShowNumber();
        Thread thread = new Thread(obj);

        NumberHelper _number = new NumberHelper(50);

        ThreadStart obj2 = () => _number.ShowNumber();
        Thread thread2 = new Thread(obj2);

        thread.Start();
        thread2.Start();

    }
    public void ConstructorOfThreadWithParameetrisedMethods()
    {
        void DisplayOfSumofNo(int sum)
        {
            Console.WriteLine("The Sum of number is" +sum);
        }

        SumOfCallBackVoid _callBack = new SumOfCallBackVoid(DisplayOfSumofNo);

        NumberHelperWithCallBack _NumberHelperwithCallBack = new NumberHelperWithCallBack(10, _callBack);

        ThreadStart obj3 = () => _NumberHelperwithCallBack.ShowNumbers();
        Thread thread3 = new Thread(obj3);

        thread3.Start();
    }
    public void JoinAndIsAliveInThread()
    {
        Console.WriteLine("Main Thread Started");

        Thread T1 = new Thread(DemoMethods.Method1)
        {
            Name = "Thread1"
        };

        Thread T2 = new Thread(DemoMethods.Method2)
        {
            Name = "Thread2"
        };

        Thread T3 = new Thread(DemoMethods.Method3)
        {
            Name = "Thread3"
        };

        T1.Start();
        T2.Start();
        T3.Start();

        if (T1.IsAlive)
            Console.WriteLine("======================= Method 1 is still alive");

        T1.Join();
        Console.WriteLine("======================= Method 1 ");
        T2.Join();
        Console.WriteLine("======================= Method 2 ");
        T3.Join();
        Console.WriteLine("======================= Method 3 ");

        if (T1.IsAlive)
            Console.WriteLine("======================= Method 1 is still alive");

        Console.WriteLine("Main Thread Ended");

    }

    public static object _lock = new object();
    public void ProtectingSharedResourcesConcurrentAccess()
    {
        int sum=0;
        Stopwatch _watch = Stopwatch.StartNew();
        Console.WriteLine("Main methods started.");

        Thread T1 = new Thread(Addition);
        Thread T2 = new Thread(Addition);
        Thread T3 = new Thread(Addition);

        T1.Start();T2.Start();T3.Start();

        T1.Join();T2.Join(); T3.Join();

        Console.WriteLine($"Total Sum is {sum}");
        _watch.Stop();

        Console.WriteLine($"Total Time is {_watch.ElapsedTicks}");

        void Addition()
        {
            for (int i = 0; i < 50000; i++)
            {


                //Interlocked.Increment(ref sum);


                //lock (_lock)
                //    sum+=i;


                bool lockTaken = false;
                Monitor.Enter(_lock, ref lockTaken);
                try
                {
                    sum++;
                }
                finally
                {
                    if (lockTaken)
                        Monitor.Exit(_lock);
                }
            }
        }
    }

    public void UnderstandingThelock()
    {
        

        for (int i = 0; i < 10; i++)
        {

            //https://www.youtube.com/watch?v=Y8Go3c-brcg

            //Task.Factory.StartNew(()=>
            //{
            //    Console.WriteLine($"Write the Serial Start : {i}");
            //    Thread.Sleep(TimeSpan.FromSeconds(2));
            //    Console.WriteLine($"Write the Serial End : {i}");
            //});

            Task.Factory.StartNew(() =>
            {
                lock(_lock)
                {
                    Console.WriteLine($"Write the Serial Start : {i}");
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    Console.WriteLine($"Write the Serial End : {i}");


                }
            });


        }
    }
}

