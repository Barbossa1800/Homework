using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1,2,3,4};
            foreach (var item in num)
            {
                Console.WriteLine(num[item]);
                break;
            }

        }
    }
}
