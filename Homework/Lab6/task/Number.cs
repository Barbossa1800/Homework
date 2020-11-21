using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab6.task
{
    public class Number
    {
        public void RecursionNumber(int[] nums)
        {
            Array.Reverse(nums);
            foreach (var item in nums)
            {
                Console.Write($"{item}\n");
            }
        }
        public void RecursionNumber(int numebr)
        {
            Console.WriteLine(numebr.ToString().Reverse().ToArray());
        }
    }
}
