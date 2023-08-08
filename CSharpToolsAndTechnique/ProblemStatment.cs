using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique
{
    public class ProblemStatment
    {

        public record Point(int x, int y);

        public record NamedPoint (string Name, int x ,int y) : Point(x,y);

        public int WithStatment()
        {

            Point P1 = new NamedPoint("A", 0, 0);
            Point P2 = P1 with { x = 5, y = 7 };


            var Banana = new
            {
                Name = "Banana",
                Price = 120
            };

            var BananaonDiscount = Banana with
            {
                Price = 99
            };

            return BananaonDiscount.Price;
        }



        public  void RecordStatmentinC()
        {
            var Nick = new Person("Nick Chapsas", new DateOnly(1997, 01, 01));

            var Nick2 = new Person("Nick Chapsas", new DateOnly(1997, 01, 01));


            var NickOverright = new PersonOverright("Nick Chapsas", new DateOnly(1997, 01, 01));
            var NickOverright2 = new PersonOverright2("Nick Chapsas", new DateOnly(1997, 01, 01)).ToString();

            var NickbutOlder = Nick with { DateofBirth = new DateOnly(1992, 06, 20) };

            var NickasClass = new PersonasClass { FullName= "Nick Chapsas",DateofBirth = new DateOnly(1997, 01, 01) };
            var NickasClass2 = new PersonasClass { FullName= "Nick Chapsas",DateofBirth = new DateOnly(1997, 01, 01) };


            var Recstatment = Nick.ToString(); // It will return all the things

            var ClassStatment = NickasClass.ToString(); // It will return only the property name

            var NickButolder = NickbutOlder.ToString();


            var Check = (Nick == Nick2); //It will return true 
            var Check2 = (NickasClass == NickasClass2); //It will return false for different object 


            var Checkreferrences = ReferenceEquals(Nick, Nick2); //It will return false 


            var (name, dateofBirth) = Nick;

            var aaa = name.ToString()+ dateofBirth.ToString();

        }
    }

    public record Person2
    {
        public string FullName { get; set; } = default!;
        public DateOnly DateofBirth { get; set; } = default!;
    }

    public record Person(string FullName, DateOnly DateofBirth);
    public record PersonOverright(string FullName, DateOnly DateofBirth)
    {
        protected PersonOverright(PersonOverright oldperson)
        {
            FullName=oldperson.FullName;
            DateofBirth= oldperson.DateofBirth;
        }
    };

    public record PersonOverright2(string FullName, DateOnly DateofBirth)
    {
        protected virtual bool PrintMembers(StringBuilder builder)
        {
            builder.Append($"Full Name Id :{FullName}");
            builder.Append($"Date of Birth :{DateofBirth}");

            return true;
        }
    };

    public class PersonasClass
    {
        public string FullName { get; set; } = default!;
        public DateOnly DateofBirth { get; set; } = default!;
    }

    public record struct PersonAsStruct(string FullName, DateOnly DateofBirth);


}
