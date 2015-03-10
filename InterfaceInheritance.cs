using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    interface Interface1
    {
        void Add(int x, int y);
        void Sub(int x, int y);
    }
    interface Interface2
    {
        void Mul(int x,int y);
        void Div(int x,int y);
    }
    class ImplementClass : Interface1, Interface2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            ImplementClass c = new ImplementClass();
            c.Add(100, 300);
            c.Sub(200, 100);
            c.Mul(80, 400);
            c.Div(200, 150);
            Console.ReadLine();
        }
    }

}
