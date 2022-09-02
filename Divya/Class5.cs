using System;
using System.Collections.Generic;
using System.Text;

namespace Divya
{
    class Class5
    {
        public static void main(string[] args)
        {
            var i = 1;
            i = "Divya";
            Console.WriteLine(i);
            Type t = i.GetType();
            dynamic j;
            j = "Divya";
            Type type = j.GetType();
            Console.WriteLine(j);
            Console.WriteLine(type);
        }
    }
}
