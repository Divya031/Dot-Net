using System;
using System.Collections.Generic;
using System.Text;

namespace Divya
{
    class Class3

    {
        public static void main3(string[] args)
        {
            Console.WriteLine("Enter the choice:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            swap(a,ref b);



        }
        public static void swap(int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("after swapping");
            Console.WriteLine("a=" + a + "\n" + "b=" + b);

        }

    }
}
