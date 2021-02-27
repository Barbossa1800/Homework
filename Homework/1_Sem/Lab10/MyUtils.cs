using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    public static class MyUtils
    {
        public static void Num(this int[] num)
        {
            Array.Sort(num);
            Array.Reverse(num);
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
        }   
    }
}
