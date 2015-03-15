using System;
namespace CSharpProject
{
    struct Structure
    {
        int x;
        public Structure(int x)
        {
            this.x = x;
        }
        public void Display()
        {
            Console.WriteLine("Method under a structure: " + this.x);
        }
        static void Main()
        {
            Structure s1; //calls parameterless constructor implicitly//
            s1.x = 10;
            s1.Display();
            Structure s2 = new Structure(20);
            s2.Display();
            Console.ReadLine();
        }
    }
}
