using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Toys
{
    class Submarine : IAccelerate, ISlowDown, IRise, IDive
    {
        public int Depth { get; set; } = 0;
        public int Speed { get; set; } = 0;
        private String Name { get; set; } = "Submarine";

        public void Accelerate(int change)
        {
            Speed += change;
        }

        public void SlowDown(int change)
        {
            Speed -= change;
        }
        public void Dive(int change)
        {
            Depth -= change;
        }

        public void Rise(int change)
        {
            if (Depth < 0)
            {
                Depth += change;
            }
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
            return Depth;
        }
    }
}
