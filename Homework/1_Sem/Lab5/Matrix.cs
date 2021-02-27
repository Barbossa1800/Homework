using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    internal class Matrix
    {
        internal int[,] CreateMatrix()
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
            return numbers;
        }
        internal void SumMainSideDiagonaluty( int[,] numbers)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += numbers[i, 3 - i];
            }
            Console.WriteLine(sum);
        }
        internal void SumMainDiaginalyty( int[,] numbers)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += numbers[i, i];
            }
            Console.WriteLine(sum);
        }
        internal void SumD( int[,] numbers)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += numbers[i, 3 - i];
            }
            Console.WriteLine(sum);
        }
    }
}
