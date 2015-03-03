using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class TestMath
    {
        static void Main()
        {
            Math m = new Math(20, 10);
            m.Add();
            m.Sub();
            m.Mul();
            m.Div();
            Console.ReadLine();
        }
    }

}
