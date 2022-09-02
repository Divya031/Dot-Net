using System;
using System.Collections.Generic;
using System.Text;

namespace Divya

{  class Class1
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter the number");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Addition");
        Console.WriteLine("Subtraction");
        Console.WriteLine("Multiplication");
        Console.WriteLine("Division");
        int c = Convert.ToInt32(Console.ReadLine());

        switch (c)
        {
            case 1:
                Console.WriteLine ("Addition of statement" + (a + b));
                break;
            case 2:
                Console.WriteLine("Subtraction of statement" + (a - b));
                break;
            case 3:
                Console.WriteLine("Multiplication of statement" + (a * b));
                break;
            case 4:
                Console.WriteLine("Division of statement" + (a % b));
                break;




        }
        
            }

        }
       

    }

