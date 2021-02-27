using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab6.SecondPart
{
    public class MagicSing
    {
        public void MagicRecursion(string[] text/*, string[] text2*/)
        {
            foreach (var item in text)
            {
                if (text != null)
                {
                    Console.Write(item.Reverse().ToArray());
                }
                else Console.WriteLine("Error");
            }
        }
        public void Mag(string[] text)
        {
            foreach (var item in text)
            {
                if (text != null)
                {
                    item.Reverse().ToArray();
                }
                else Console.WriteLine("Error");
            }
            string newword = null;
            string textold = Regex.Replace(text[1], " {2,}", "    ");
            foreach (var el in textold)
            {
                if (Char.IsWhiteSpace(el))
                {
                    newword += ','.ToString();
                    continue;
                }
                newword += el.ToString();
            }
            Console.WriteLine($"New string: {newword}");
        }
    }
}
