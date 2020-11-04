using Lab8._1;
using System;
using System.Text;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Garage garage = new Garage("JhonFm", new System.Collections.Generic.List<Cars>
            {
                new Cars("Audi", "R8", "Black"),
                new Cars("Lamba", "Aventador", "Black"),
                new Cars("Tesla", "Model S", "White"),
                new Cars("Tesla", "Model 3", "White"),
                new Cars("Tesla", "Model X", "White")
            });
            var allCars = garage.GetAllCars();
            garage.ShowCars(allCars);
            var car = garage.GetCarsByModel(Console.ReadLine()); //R8
            Console.WriteLine(car.Count); //1
        }
    }
}
