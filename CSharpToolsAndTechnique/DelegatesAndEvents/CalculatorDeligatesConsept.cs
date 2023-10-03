namespace CSharpToolsAndTechnique.DelegatesAndEvents;


public class CalculatorDeligatesConsept
{
    public delegate int CalculatorDeligates(int x, int y);
    public static void PrintTheResult(CalculatorDeligates calculatorDeligates)
    {
        Console.WriteLine($"The Result is {calculatorDeligates}");
    }

    public static CalculatorDeligates SumValue = (int x, int y) =>
    {
        return x + y;
    };

    public static CalculatorDeligates SubtractValue = (int x, int y) =>
    {
        return x - y;
    };
}

public static class ImplementationofCalculatorDeligates
{
    public static void ImplementationofCalculator()
    {
        CalculatorDeligatesConsept.PrintTheResult(CalculatorDeligatesConsept.SumValue);

        CalculatorDeligatesConsept.PrintTheResult(CalculatorDeligatesConsept.SubtractValue);
    }
}
