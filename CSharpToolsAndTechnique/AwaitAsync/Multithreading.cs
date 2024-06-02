namespace CSharpToolsAndTechnique.AwaitAsync;

public  class Multithreading
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main thread is done. ");

        Console.ReadLine();
    }

    static int AddNumber(int a , int b)
    {
        return a+b;
    }
}

