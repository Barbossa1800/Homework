using System;
using System.Security.Cryptography;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[4, 4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    numbers[i, j] = rnd.Next(0, 10);
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //суммируем начиная с правого верхнего элемента
            //суммируем начиная с правого верхнего элемента
            int sum = 0;
            for (int i = 4; i > 0; i++)
            {
                for (int j = i; j <= 4; --j)
                {
                    sum += numbers[i - j, 4 - 1 - j];
                }
            }
            Console.WriteLine($"{sum}");
            //sum1 = sum2 = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum1 += a[i][i];
            //    sum2 += a[i][n - 1 - i];
            //}

        }
               
    }
}
