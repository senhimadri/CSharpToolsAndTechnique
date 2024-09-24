namespace CSharpToolsAndTechnique.ImplicitOperators;

public class Celsius
{
	public Celsius(double value) => _value = value;
	public double _value { get; }

	public static implicit operator Fahrenheit(Celsius celcious)
	{
		double fahrenheit = celcious._value * 9 / 5 + 32;
		return new Fahrenheit(fahrenheit);
	}

}

public class Fahrenheit
{
	public Fahrenheit(double value) => _value = value;
	public double _value { get; }
}

public class ImplicitOperatorsProgramImplementation
{
	public static void Main()
	{
		Celsius cel = new Celsius(25);
		Fahrenheit fahrenheit = cel;

		Console.WriteLine(fahrenheit._value);
	}
}
