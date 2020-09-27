using System;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №1, варіант-14, Медко М.М.");
            Data data = new Data();
            Console.WriteLine($"Час, за який два тіла зустрінутсья (години, хвилини): {Math.Round(data.MeetingTime(), 1)} "); 
        }
    }
}
