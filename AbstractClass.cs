using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    abstract class AbstractParent
    {
        public void Add(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x -y);
        }
        public abstract void Mul(int x,int y);
        public abstract void Div(int x, int y);

    }
    class AbstractChild : AbstractParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            AbstractChild c = new AbstractChild();
            c.Add(100, 300);
            c.Sub(200, 100);
            c.Mul(80, 400);
            c.Div(200, 150);
            Console.ReadLine();

            //we can call those methods by using parents class reference also//
            AbstractChild c1 = new AbstractChild();
            AbstractParent p = c1; //here p is a parent class reference which is created using the child class object//
            p.Add(10,20);
            p.Sub(20, 10);
            p.Mul(20, 30);
            p.Div(20, 10);
            


        }
    }
}
