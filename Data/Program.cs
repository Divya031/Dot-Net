using System;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the no.");
            n= Convert.ToInt32(Console.ReadLine());
            if(n % 2 ==0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
