using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_4
{
    internal class MyClass: IShowA,IShowB
    {
        public void Show()
        {
            Console.WriteLine("My class Show is completed");
        }
        void IShowA.Show(){
            Console.WriteLine("Explicit realization IshowA");
        }

        void IShowB.Show()
        {
            Console.WriteLine("Explicit realization IshowB");
        }
    }
}
