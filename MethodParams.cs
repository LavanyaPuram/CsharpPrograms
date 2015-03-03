using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class MethodParams
    {
            //Method without any input and return type//
            public void Test1()
            {
                int x=5;
                for(int i=1; i<=10;i++)
                {
                    Console.WriteLine("{0}*{1}={2}",x,i,x*i);
                }
            }
             //Method with input and no return type// 
            public void Test2(int m,int n)
            {
                for(int i=1;i<=n;i++)
                {
                    Console.WriteLine("{0}*{1}={2}",m,i,m*i);
                }
            }
               //Method with return type but no input//
            public string Test3()
            {
                string str="Hello World";
                str=str.ToUpper();
                return str;
            }
            //Method with input and return type//
            public string Test4(string str)
            {
                str=str.ToUpper();
                return str;
            }
            static void Main()
            {
                MethodParams p = new MethodParams();
                p.Test1();
                p.Test2(6, 5);
                string s1= p.Test3();
                Console.WriteLine(s1);
                string s2 = p.Test4("Hello,How are you");
                Console.WriteLine(s2);
                Console.ReadLine();
            }
    }
}
