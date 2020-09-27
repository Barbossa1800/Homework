using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    internal class Matrix
    {
        internal int[,] CreateMatrix()
        {
            int[,] mas = new int[4, 4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mas[i, j] = rnd.Next(0, 10);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return mas;
        }
        internal void SumMainSideDiagonaluty(ref int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += arr[i, 3 - i];
            }
            Console.WriteLine(sum);
        }
        internal void SumMainDiaginalyty(ref int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += arr[i, i];
            }
            Console.WriteLine(sum);
        }
        internal void SumD(ref int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += arr[i, 3 - i];
            }
            Console.WriteLine(sum);
        }
    }
}
