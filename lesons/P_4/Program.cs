using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemple 4
            MyClass show = new MyClass();
            show.Show();
            IShowA showA = new MyClass();
            showA.Show();
            IShowB showB = new MyClass();
            showB.Show();

        }
    }
}
