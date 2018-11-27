using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class SchoolState : State
    {
        public void DoAction(Student student)
        {
            Console.WriteLine("Student is in at school state");
            student.setState(this);
        }
    }
}
