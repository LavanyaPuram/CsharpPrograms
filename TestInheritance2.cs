using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpProject

{
    class TestInheritance2:TestInheritance1
    {
        public TestInheritance2(int x,int y):base(x)
        {
            Console.WriteLine("child class constructor is called: "+y);
        }
        static void Main()
        {
            TestInheritance2 t2 = new TestInheritance2(10,20);
            Console.ReadLine();
        }
    }
}
