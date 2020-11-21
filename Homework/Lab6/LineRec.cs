using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    public class LineRec
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
    }
}
