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
            SleepState sleepState = new SleepState();
            sleepState.DoAction(student);
            Console.WriteLine(student.getState().ToString());
            SchoolState atSchoolState = new SchoolState();
            atSchoolState.DoAction(student);
            Console.WriteLine(student.getState().ToString());
            Console.ReadLine();
        }
    }
}
