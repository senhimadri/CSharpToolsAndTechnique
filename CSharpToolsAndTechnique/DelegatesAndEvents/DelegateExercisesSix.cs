namespace CSharpToolsAndTechnique.DelegatesAndEvents;

internal class DelegateExercisesSix
{
    public delegate int Mydeligate(int intValue);

    int MethodOne(int ValueOne)
    {
        return ValueOne * 5 ;
    }

    int MethodTwo(int MethodOne)
    {
        return MethodOne * 3 ;
    }

    public void MethodThree()
    {
        Mydeligate mydeligate = new Mydeligate(MethodOne);

        MethodFour(mydeligate);

        mydeligate = new Mydeligate(MethodTwo);


        MethodFour(mydeligate);
    }

    public void MethodFour(Mydeligate mydeligate)
    {
        int result = mydeligate(10);

        Console.WriteLine(result);
    }
}
