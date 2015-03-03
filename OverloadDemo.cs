using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class OverloadDemo
    {
        public void Show()
        {
            Console.WriteLine("No parameters");
        }
        public void Show(int x)
        {
            Console.WriteLine(x);
        }
        public void Show(string s)
        {
            Console.WriteLine(s);
        }
        public void Show(int x,string s)
        {
            Console.WriteLine(x+" "+s);
        }
        static void Main()
        {
            OverloadDemo d = new OverloadDemo();
            d.Show();
            d.Show(10);
            d.Show("hello");
            d.Show(20, "lavanya");
            Console.ReadLine();
        }
    }
}
