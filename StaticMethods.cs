using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class StatMets
    {
        int x = 100;
        static int y = 300;
        public static void Add()
        {
            StatMets s = new StatMets();
            Console.WriteLine(s.x + y);
        }
        static void Main()
        {
            StatMets.Add();
            Console.ReadLine();
        }
    }
}
