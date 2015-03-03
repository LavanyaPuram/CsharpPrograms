using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Params
    {
        //Method with dafault values to parameters//
        public void AddNums(int x, int y = 50, int z = 30)
        {
            Console.WriteLine(x + y + z);
        }
        //Method with input and output parameters//
        public void Math1(int a, int b, ref int c, ref int d)
        {
            c = a + b;
            d = a - b;
        }
        public void Math2(int a, int b, out int c, out int d)
        {
            c = a * b;
            d = a / b;
        }
        public static void Main()
        {
            Params p = new Params();
            p.AddNums(100);
            p.AddNums(10, 90);
            p.AddNums(10, z: 40);
            p.AddNums(100, 100, 100);
            int x =0,y=0;
            p.Math1(100, 50, ref x, ref y);
            Console.WriteLine(x + " " + y);
            int m, n;
            p.Math2(100, 50, out m, out n);
            Console.WriteLine(m+ " " + n);
            Console.ReadLine();
        }
    }
}
