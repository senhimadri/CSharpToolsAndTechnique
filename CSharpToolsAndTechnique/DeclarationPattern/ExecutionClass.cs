using CSharpToolsAndTechnique.DeclarationPattern.DeclarationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.DeclarationPattern;

public class ExecutionClass
{

    //Traditional Way

    public string TraditionalWays()
    {

        var Person = new StudentDTO();

        if ((Person !=null) && (Person is StudentDTO))
        {
            var Student = (StudentDTO)Person;

            var Name = Student.StudentName;

            return Name;

        }

        return "";
    }


    public string ModernMethods()
    {

        var Person = new StudentDTO();

        if (Person is StudentDTO student)
        {
            var Name = student.StudentName;
            return Name;

        }

        return "";
    }
}

