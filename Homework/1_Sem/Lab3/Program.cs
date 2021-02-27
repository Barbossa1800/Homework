using System;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №3, варіант-14, Медко М.М.");
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            if (num.Length == 3)
            {
                double n1 = Convert.ToDouble(num[0].ToString());
                double n2 = Convert.ToDouble(num[1].ToString());
                double n3 = Convert.ToDouble(num[2].ToString());
                Console.WriteLine(n2 - n1 == n3 - n2 || n2 + n1 == n3 + n2); //1 -зростаюча, 2-спадаюча
            }
        }
    }
}
