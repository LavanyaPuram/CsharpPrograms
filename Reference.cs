using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Reference
    {
        int x = 100;
        static void Main()
        {
            Reference r1 = new Reference();
            Reference r2;//variable of a class//
            r2 = r1;    //r2 is a reference of a class//
            Console.WriteLine(r1.x + " " + r2.x);//we can call the members of a class through the reference//
            r1.x = 200;
            Console.WriteLine(r1.x + " " + r2.x);
            r1 = null;
            Console.WriteLine(r2.x);
            //Console.WriteLine(r1.x);//invalid//
            Console.ReadLine();

        }
    }
}
