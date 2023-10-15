namespace CSharpToolsAndTechnique.DelegatesAndEvents;

internal class DeligateExerciseFour
{
    public delegate int MyDeligate(int intValue);

    public int MethodOne(int OneValue )
    {
        return OneValue * 5 ;
    }

    public int MethodTwo(int TwoValue ) 
    { 
        return  TwoValue * 10 ;
    }

    public void MethodThree()
    {
        MyDeligate myDeligate = new MyDeligate(MethodOne);

        int Result1 = myDeligate(10);

        myDeligate = new MyDeligate(MethodTwo);

        int Result2 = myDeligate(10);

        Console.WriteLine($"Method One : {Result1} , Method Two : {Result2}");

        Console.ReadLine();
    }

}
