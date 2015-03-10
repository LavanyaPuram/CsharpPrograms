using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class StatVars
    {
        int x;
        const float pi = 3.14f;
        readonly bool flag;
        static int y=50;
        public StatVars(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main()
        {
            Console.WriteLine(StatVars.y);
            Console.WriteLine(StatVars.pi);
            StatVars s1 = new StatVars(10,true);
            StatVars s2 = new StatVars(20, false);
            Console.WriteLine(s1.x + " " + s2.x);
            Console.WriteLine(s1.flag + " " + s2.flag);
            Console.ReadLine();
        }
    }
}
