using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №7, варіант-14, Медко М.М.");
            Lists lists = new Lists();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter string value: ");
                lists.AddValue(Console.ReadLine());
            }
            Console.WriteLine(lists.GetIndexByValue(Console.ReadLine()));
            var res = lists.GetListAsArray();

        }
    }
}
