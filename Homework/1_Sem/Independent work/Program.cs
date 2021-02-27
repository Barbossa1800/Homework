using System;
using System.Text;

namespace Independent_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Выбор напитка");
            ProductAvailability productAvailability = new ProductAvailability();
            while (true)
            {
                Console.Write("За какими критерями вы хотите осуществлять поиск?\n 1 - полынй список\n 2 - короткий\nВаш выбор:");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp==1)
                {
                    productAvailability.Request("Galliano ",  "Italy",  780,  35,  "Baboo",  0.75);
                    continue;
                }
                if (temp==2)
                {
                    productAvailability.Request("Scotland", 35, "Damboo");
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Програма завершила выполнение!");
        }
    }
}
