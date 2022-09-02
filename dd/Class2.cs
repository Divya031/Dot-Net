using System;
using System.Collections.Generic;
using System.Text;

namespace dd
{
    class Class2
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Case 1 is executed");
                    break;
                case 2:
                    Console.WriteLine("case 2 is executed");
                    break;
            }
        }
    }
}
