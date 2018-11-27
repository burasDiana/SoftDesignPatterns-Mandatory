using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Student
    {
        private State state;

        public Student()
        {
            this.state = null;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public State getState()
        {
            return state;
        }

    }
}
