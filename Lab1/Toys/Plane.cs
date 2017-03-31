using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Toys
{
    class Plane : IAccelerate, ISlowDown, IRise, IDive
    {
        public int Speed { get; set; } = 0;
        public int Height { get; set; } = 0;
        private String Name { get; set; } = "Plane";

        public void Accelerate(int change)
        {
            Speed += change;
        }

        public void SlowDown(int change)
        {
            if (Speed > 0)
            {
                Speed -= change;
            }
        }

        public void Dive(int change)
        {
            if (Height > 0)
            {
                Height -= change;
            }
        }

        public void Rise(int change)
        {
            Height += change;
        }
        public override string ToString()
        {
            return Name;
        }

        public int getSpeed()
        {
            return Speed;
        }

        public int getHeight()
        {
            return Height;
        }
    }
}
