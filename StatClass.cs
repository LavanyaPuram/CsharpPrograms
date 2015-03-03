using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    static class StatClass
    {
        static int x = 10;
        static int y = 20;
        public static void Add()
        {
            Console.WriteLine(x + y);
        }
        static void Main()
        {
            Add();
            Console.ReadLine();
        }
    }
}
