using System;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №2, варіант-14, Медко М.М.");
            Console.WriteLine($"Common result is {CalculateP(6, 10)} equals formula");
        }
        
        static double CalculateP(int n, int k)
        {
            if (n > k)
                return default;
            double result = 1;
            for (int i = 0; i < k; i++)
            {
                if (n * n >= 0 && n * n <= n * k)
                    result *= (Math.Pow(-1, k) * k + 8) / (Math.Pow(2 * k, 2) + k + 7);
            }
            return result;
        }
    }
}
