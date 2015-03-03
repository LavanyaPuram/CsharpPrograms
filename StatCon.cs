using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class StatCon
    {
        static StatCon()
        {
            Console.WriteLine("Static constructor is called");
        }
        public StatCon()
        {
            Console.WriteLine("Non-Static constructor is called");
        }
        static void Main()
        {
            Console.WriteLine("Main method is called");
            StatCon s1 = new StatCon();
            StatCon s2 = new StatCon();
            StatCon s3 = new StatCon();
            Console.ReadLine();
        }
    }
}
