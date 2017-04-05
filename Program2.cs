using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Array tab = new Array();

            tab[0] = 11111;
            Console.WriteLine(tab[0]);
            tab[102] = 102;
            
            tab.add(3);
            tab[202] = 202;


            Console.WriteLine(tab[0] + " " + tab[102] + " " + tab[202]);
        }
    }
}
