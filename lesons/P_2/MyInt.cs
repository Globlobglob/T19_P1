using System;

namespace InterfaceTest
{/// <summary>
/// Realization interface 
/// </summary>
    internal interface MyInt
    {
        void Show1();
        void Show2();
    }
    /// <summary>
    /// implements my abstract interface 
    /// </summary>
    abstract class MyClass : MyInt
    {
        public abstract void  Show1();

        public abstract void Show2();
       

    }
    /// <summary>
    /// abstract inherit class Child
    /// </summary>
   class ChildCLass : MyClass
    {
        /// <summary>
        /// redefine our methods
        /// </summary>
        public override void Show1()
        {
            Console.WriteLine("SHow 1 is implemented");
        }


        public override void Show2() {
            Console.WriteLine("Show 2 is implemented");
        }
    }

}
