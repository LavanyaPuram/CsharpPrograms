using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class SimpleArray
    {
        static void Main()
        {
            int[] arr = {10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40};
            int[] brr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
            Console.WriteLine();
            Console.WriteLine("The below one is the array sorting");
            Array.Sort(arr);
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("The below one is the array Reversing");
            Array.Reverse(arr);
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("The below one is the array Copying");
            Array.Copy(arr, brr, 10);
            foreach (int i in brr)
                Console.Write(i + " ");
            Console.ReadLine();
        }

    }
}
