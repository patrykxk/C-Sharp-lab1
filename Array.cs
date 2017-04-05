using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Array
    {
        static int N = 100;
        private int[] tab = new int[N];

        public int this[int i] { 
            get {
                if (i < tab.Length)
                {
                    return tab[i];
                }
                else {
                    throw new System.IndexOutOfRangeException();
                }
            }
            set {
               
                tab[i] = value;

            }
        }
        public void add(int x){
            tab[tab.Length-1] = x;
        }
         
    }
}
