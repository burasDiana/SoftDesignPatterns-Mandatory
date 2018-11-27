using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class StudentSchoolState : State
    {
        public void DoAction(Student student)
        {
            Console.WriteLine("Student is in school state");
            student.setState(this);
        }
    }
}
