using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            var mat = matrix.CreateMatrix();
            matrix.SumMainSideDiagonaluty(ref mat);
            matrix.SumMainDiaginalyty(ref mat);
            matrix.SumD(ref mat);
        }
    }
}
