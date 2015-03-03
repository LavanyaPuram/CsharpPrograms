using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class First
    {
        int x = 10;
        static void Main()
        {
            First f1 = new First();
            First f2 = new First();
            Console.WriteLine(f1.x+" "+f2.x);
            f1.x = 20;
            Console.WriteLine(f1.x+" "+f2.x);
            Console.ReadLine();
        }
    }
}
