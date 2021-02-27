using System;
using System.Text;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №4, варіант-14, Медко М.М.");
            var arr = new int[,] { { 1, 2 }, { 4, 56 }, { 45, 2 }, { 13, 5 }, { 67, 5 } };
            int Max = 1, Min = 1;
            for (int i = 0; i <5 ; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (arr[i,j]>Max)
                    {
                        Max = arr[i, j];
                    }
                    if (arr[i,j]<Min)
                    {
                        Min = arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Max: {Max}, Min: {Min}");
        }
    }
}
