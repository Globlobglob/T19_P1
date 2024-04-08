using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_3
{
    internal class MyClass:IShowA,IShowB
    {
        public void ShowA()
        {
            Console.WriteLine("ShowA is imp");
        }

        public void ShowB() { Console.WriteLine("ShowB is Imp"); }
    }
}
