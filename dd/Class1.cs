using System;
using System.Collections.Generic;
using System.Text;

namespace dd
{
    class Class1
    {
        public static void main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            if(age>60)
            {
                Console.WriteLine("Senior Citizen");
            }
            else
            {
                if(age>18)
                {
                    Console.WriteLine("Eligible");
                }
                else
                {
                    Console.WriteLine("not eligible");
                }

            }
        }
    }
}
