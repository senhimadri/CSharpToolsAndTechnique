using CSharpToolsAndTechnique.DelegatesAndEvents;
using CSharpToolsAndTechnique.CollectionsUsingRowCode;
using System.Text;


Type type = typeof(string);



StringBuilder x = new StringBuilder("Hello");

StringBuilder y = x;

x.Append(" World");






DeligateExerciseFour threeImp = new DeligateExerciseFour();
threeImp.MethodThree();

var p1 = new List<TestCalssDTO>()
{
    new TestCalssDTO(){ Id=1, Name="Himadri"},
    new TestCalssDTO(){ Id=2, Name="Tousif"},
};

//var p2 = p1.Select(x => x with { Name= "Himadri" });





