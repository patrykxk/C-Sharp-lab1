using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Toys
{
    class Car : IAccelerate, ISlowDown
    {
        public int Speed { get; set; } = 0;
        private String Name { get; set; } = "Car";

        public void Accelerate(int change)
        {
            Speed += change;
        }

        public void SlowDown(int change)
        {
            Speed -= change;
        }
        public override string ToString()
        {
            return Name;
        }
        public int getSpeed()
        {
            return Speed;
        }
    }
}
