using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class ConParam
    {
        int x;
        public ConParam(int a)
        {
            x = a;
        }
        void Display()
        {
            Console.WriteLine("The value of x is:{0}", x);
        }
        static void Main()
        {
            ConParam p1 = new ConParam(10);
            ConParam p2 = new ConParam(20);
            ConParam p3 = new ConParam(30);
            p1.Display();
            p2.Display();
            p3.Display();
            Console.ReadLine();
        }
    }
}
