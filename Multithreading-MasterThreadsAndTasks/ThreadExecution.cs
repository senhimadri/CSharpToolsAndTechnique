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



}

