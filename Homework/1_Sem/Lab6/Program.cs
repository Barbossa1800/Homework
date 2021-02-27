using Lab6.FirstPart;
using Lab6.SecondPart;
using System;
using System.Text.RegularExpressions;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.RecursionNumber(new int[] { 1, 2, 3, 4, 5, 5 });
            number.RecursionNumber(123);
            Line line = new Line();
            line.RecursionString(new string[] { "God" });
            line.RecursionString();
            DoubleNumber doubleNumber = new DoubleNumber();
            doubleNumber.Sort();
            MagicSing magicSing = new MagicSing();
            magicSing.MagicRecursion(new string[2] { "Nikita", "Dut" });
            Don_tReverse don_TReverse = new Don_tReverse();
            don_TReverse.DoReveres();
            int[] num;
            don_TReverse.DoReveres3(out num);
            num = new int[] { 1, 2, 3, 4 };
            don_TReverse.DoReveres4(ref num);
        }

    }
}
