using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            var mat = matrix.CreateMatrix();
            matrix.SumMainSideDiagonaluty( mat);
          //  matrix.SumMainDiaginalyty( mat);
            matrix.SumD( mat);
        }
    }
}
