using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class ConDemo
    {
        public static void Method()
        {
            Console.WriteLine("Static method is called");
        }
        public ConDemo()
        {
            Console.WriteLine("Constructor is called");
        }
        public void Demo()
        {
            Console.WriteLine("Method is called");
        }
        static void Main()
        {
            ConDemo c1 = new ConDemo();
            ConDemo c2 = new ConDemo();
            ConDemo c3 = c2;
            ConDemo.Method();
            c1.Demo();
            c2.Demo();
            c3.Demo();
            Console.ReadLine();
        }
    }
}
