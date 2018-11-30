﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class StudentSleepState : State
    {
        public void DoAction(Student student)
        {
            Console.WriteLine("Student is in sleep state");
            student.setState(this);
        }
    }
}