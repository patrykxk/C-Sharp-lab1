using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IDive
    {
        void Dive(int change);
        int getHeight();
    }
    interface IRise
    {
        void Rise(int change);
        int getHeight();
    }

    interface IAccelerate
    {
        void Accelerate(int change);
        int getSpeed();
    }
    interface ISlowDown
    {
        void SlowDown(int change);
        int getSpeed();
    }


}
