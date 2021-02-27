    using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6.SecondPart
{
    public class Don_tReverse
    {
        public void DoReveres()
        {
            int[] num = { 1, 3, 4, 9, 8 };
            for (int i = 0; i < num.Length / 2; i++)
            {
                int temp = num[i];
                num[i] = num[num.Length - i - 1];
                num[num.Length - i - 1] = temp;
            }
            Console.Write(string.Join(",", num));
        }
        public void DoReveres2(int[] num)
        {
            for (int i = 0; i < num.Length/2; i++)
            {
                int temp = num[i];
                num[i] = num[num.Length - i - 1];
                num[num.Length - i - 1] = temp;
            }
        }
        public void DoReveres3( out int[] num)
        {
            num = new int[] {1,2,3,4};
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
        }
        public void DoReveres4(ref int[] num)
        {
            
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i]);
            }


        }
    }
}
