using System;

namespace Divya
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter the Number");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                if (a > b && a > c)
                {
                    Console.WriteLine("A is greater");
                }
                else if (b > a && b > c)
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



