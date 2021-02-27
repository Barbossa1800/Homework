using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6.FirstPart
{
    public class Line
    {
        public void RecursionString(string[] sts)
        {
            foreach (var item in sts)
            {
                if (sts != null)
                {
                    Console.WriteLine(item.Reverse().ToArray());
                }
                else Console.WriteLine("Error");
            }
        }
        public void RecursionString()
        {
            string word = "Dut for ever!";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }    
        }
    }
}
