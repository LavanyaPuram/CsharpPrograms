using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpProject

{
    class Class2:Class1
    {
        public Class2()
        {
            Console.WriteLine("Class 2 constructor called");
        }
        public void Test3()
        {
            Console.WriteLine("Third method called");
        }
        static void Main()
        {
            Class2 c2 = new Class2();//c2 is the child class object//
            Class1 c1 = c2; //c1 is parent class reference//
            Class2 obj = c1 as Class2;//converting the parent class reference back into child class reference//
            obj.Test1();//calling members using child class reference//
            obj.Test2();
            obj.Test3();
            Console.ReadLine();

            //object obj = new object();
            //Console.WriteLine(obj.GetType());
            //Class1 c1 = new Class1();
            //Console.WriteLine(c1.GetType());
            //Class2 c2 = new Class2();
            //Console.WriteLine(c2.GetType());
            //Console.ReadLine();
        }
    }
}
