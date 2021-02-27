using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab6.FirstPart
{
    public class DoubleNumber
    {
        public void Sort()
        {
            double num = 123.456;
            var temp = num.ToString().Split(',');
            foreach (var item in temp)
            {
                var array = item.ToArray();
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write(array[i]);
                }
                Console.Write(".");
            }        
        }
        public void Sort(double num)
        {
            var temp = num.ToString().Split(',');
            foreach (var item in temp)
            {
                var array = item.ToArray();
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write(array[i]);
                }
                Console.Write(".");
            }
        }
    }
}
