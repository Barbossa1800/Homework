using System;
using System.Text;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №5, варіант-14, Медко М.М.");
            Matrix matrix = new Matrix();
            var mat = matrix.CreateMatrix();
            matrix.SumMainSideDiagonaluty( mat);
            matrix.SumMainDiaginalyty( mat);
            matrix.SumD( mat);
        }
    }
}
