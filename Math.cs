using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Math
    {
        int x, y;
        public Math(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Add()
        {
            Console.WriteLine(x + y);
        }
        public void Sub()
        {
            Console.WriteLine(x - y);
        }
        public void Mul()
        {
            Console.WriteLine(x * y);
        }
        public void Div()
        {
            Console.WriteLine(x / y);
        }
    }
}
