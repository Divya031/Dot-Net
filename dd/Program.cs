using System;

namespace dd
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age");
            age= Convert.ToInt32( Console.ReadLine( ));
            if(age>=60)
            {
                Console.WriteLine("senior citizen");
            }
            else if(age>=18)
            {
                    Console.WriteLine("eligible for voting");
            }
             else
             {
                    Console.WriteLine("Not eligible for voting");
             }
            }
            

        }
    }

