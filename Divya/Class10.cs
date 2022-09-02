using System;
using System.Collections.Generic;
using System.Text;

namespace Divya
{
    class Class10
    {
        public static void main(string[] args)
        {
            int[] sample = new int[3];
            for(int i=0;i<sample.Length;i++)
            {
                Console.WriteLine("Value of i[" + i + "]");
                 sample[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < sample.Length; i++)
            {
                Console.Write("After that value is"+i);
                Console.WriteLine(sample[i]);
                
            }

        }
    }
}
