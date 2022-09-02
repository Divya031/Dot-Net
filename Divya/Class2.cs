using System;

namespace Divya
{
    class Class2
    {
        public static void main2(string[] args)
        {
            Console.WriteLine("Enter the choice:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            swap(a, b);



        }
        public static void swap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("after swapping");
            Console.WriteLine("a=" + a + "\n" + "b=" + b);

        }

    }
}
