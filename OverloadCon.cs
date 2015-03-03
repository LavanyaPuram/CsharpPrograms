using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class OverloadCon
    {
        int x;
        public OverloadCon()
        {
            this.x = 10;
        }
        public OverloadCon(int x)
        {
            this.x = x;
        }
        public void Display()
        {
            Console.WriteLine("the value of x is {0}", x);
        }
        static void Main()
        {
            OverloadCon c1 = new OverloadCon();
            OverloadCon c2 = new OverloadCon(20);
            c1.Display();
            c2.Display();
            Console.ReadLine();
        }
    }
}
