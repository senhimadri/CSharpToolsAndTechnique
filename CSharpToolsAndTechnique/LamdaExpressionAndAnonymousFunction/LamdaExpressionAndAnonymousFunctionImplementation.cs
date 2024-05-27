using System.Reflection.PortableExecutable;

namespace CSharpToolsAndTechnique.LamdaExpressionAndAnonymousFunction;



internal class LamdaExpressionAndAnonymousFunctionImplementation
{
    public delegate bool FilterDeligates(PersonClass p);

    public void Implementation()
    {

        List<PersonClass> people = new List<PersonClass>()
        {
            new PersonClass(){ Name = "Himadri", Age = 27},
            new PersonClass(){ Name = "Alamin", Age = 23},
            new PersonClass(){ Name = "Rasidul", Age = 35},
            new PersonClass(){ Name = "Imdad", Age = 17},
        };


        FilterDeligates filter = delegate (PersonClass P)
        {
            return P.Age >=20 && P.Age<=30;
        };

        DisplayPeople("Kids",people,filter);

        DisplayPeople("All", people, filter: delegate (PersonClass p) { return true; });

        string SearchKeyword = "A";

        DisplayPeople($"Age > 20 with search Keyword {SearchKeyword}", people, (p) =>
        {
            if (p.Name.Contains(SearchKeyword) && p.Age>=20)
                return true;

            return false;
        });

        DisplayPeople("Age 25", people, p => p.Age==25);
    }


    static void DisplayPeople(string title, List<PersonClass> people , FilterDeligates filter)
    {


    }
}

public class PersonClass
{
    public string Name { get; set; }
    public int Age { get; set; }
}

