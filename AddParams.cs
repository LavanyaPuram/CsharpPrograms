using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class AddParams
    {
        static void Main(string[] args)
        {
            int sum = 0;
            foreach (string str in args)
                sum = sum + int.Parse(str);
            Console.WriteLine("Sum of all numbers is:{0}",sum);
            Console.ReadLine();
        }
    }
}
