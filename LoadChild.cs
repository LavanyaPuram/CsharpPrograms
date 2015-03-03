using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class LoadChild:LoadParent
    {
        public void Test(int x)
        {
            Console.WriteLine("child test method" + x);
        }
        public override void Show()
        {
            Console.WriteLine("child overriden show method");
        }
        public new void Display()
        {
            Console.WriteLine("child display method");// method hiding//
        }
        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Test();
            c.Test(10);
            c.Show();
            c.Display();
            Console.ReadLine();
        }
    }
}
