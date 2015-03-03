using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class LoadParent
    {
        public LoadParent()
        {
            Console.WriteLine("parent constructor");
        }
        public void Test()
        {
            Console.WriteLine("parent test method");

        }
        public void Display()
        {
            Console.WriteLine("Parent display method ");
        }
        public virtual void Show()
        {
            Console.WriteLine("parent show method");
        }
    }
}
