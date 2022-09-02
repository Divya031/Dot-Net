using System;
using System.Collections.Generic;
using System.Text;

namespace Divya
{
    class Class4
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter the value");
            string s = (Console.ReadLine());
            int result;
            bool flag = int.TryParse(s, out result);
            if(flag==true)
            {
                Console.WriteLine("numeric value");
            }
            else
            {
                Console.WriteLine("Not numeric value");
            }

        }
    }
}
