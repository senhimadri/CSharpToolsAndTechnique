namespace CSharpToolsAndTechnique.DelegatesAndEvents;

internal class DeligatesExerciseOne
{
    public delegate void MyDeligates();

     void MethodOne()
    {
        Console.WriteLine("Method One");
        Console.ReadLine();
    }

    public void MethodTwo()
    {
        MyDeligates myDeligates = new MyDeligates(MethodOne);
        myDeligates();
    }
}

public class DeligatesExerciseOneImplementation
{
    public void Implementation()
    {
        DeligatesExerciseOne deligatesExerciseOne = new DeligatesExerciseOne();
        deligatesExerciseOne.MethodTwo();
    }
}
