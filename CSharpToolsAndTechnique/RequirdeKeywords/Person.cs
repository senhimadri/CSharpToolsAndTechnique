using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.RequirdeKeywords;

public class Person
{
    public Guid Id { get; set; }= Guid.NewGuid();
    public required string FullName { get; init; }


}

public class RequiredKeyImplementation
{
    public void Implementation()
    {
        var person = new Person() { FullName=""};
    }
}
