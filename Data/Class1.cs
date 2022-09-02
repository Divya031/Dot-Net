using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class Class1
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter the choice");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine("A is greater");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("Bis greater");
            }
            else
            {
                Console.WriteLine("C is greater");
            }
        }
    }
}
