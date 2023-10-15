namespace CSharpToolsAndTechnique.AccessModifier;

public class Person
{
    private DateTime _birthdate;

    public void SetBirthday(DateTime birthdate)
    {
        _birthdate = birthdate;
    }

    public DateTime GetBirthdate()
    {
        return _birthdate;
    }
}


public class AccessModifierImplementation
{

    public void Implementation()
    {
        var person = new Person();

        person.SetBirthday(new DateTime(1997,01,01));

        Console.WriteLine(person.GetBirthdate());


    }
}
