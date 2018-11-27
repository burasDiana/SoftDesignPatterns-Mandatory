using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            StudentSleepState sleepState = new StudentSleepState();
            sleepState.DoAction(student);
            Console.WriteLine(student.getState().ToString());
            StudentSchoolState atSchoolState = new StudentSchoolState();
            atSchoolState.DoAction(student);
            Console.WriteLine(student.getState().ToString());
            Console.ReadLine();
        }
    }
}
