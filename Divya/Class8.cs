using System;
using System.Collections.Generic;
using System.Text;

namespace Divya
{
    class Class8
    {
        public static void main(string[] args)
        {
            sum(2, 5);
            int result;
            sumout(2, 4, out result);
            
            Console.WriteLine(result);
            sumnamed(a: 1, c: 2, b: 3);
            sumoption(30, 20);

        }
        public static void sum( in int a,in int b)
        {
            Console.WriteLine(a + b);
        }
        public static void sumout(int a,int b,out int c)
        {
            c= a + b;
        }
        public static void sumnamed(int a,int b,int c)
        {
            Console.WriteLine("result is" + (a + b + c));
        }
        public static void sumoption(int a,int b,int c=20)
        {
            Console.WriteLine("result will be" + (a + b + c));
        }
    }

   
}
