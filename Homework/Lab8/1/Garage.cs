using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8._1
{
    public class Garage
    {
        List<Cars> cars = new List<Cars>()
        {
            new Cars(){Name = "Mercedes", Color= "Black", Speed= 120,  YearOfProdaction= "2020 " },
            new Cars(){Name = "Tesla", Color= "White", Speed= 150, YearOfProdaction= "2020 " },
            new Cars(){Name = "BMW", Color= "White", Speed= 180, YearOfProdaction= "2015 " },
        };

        public void RemoveCar()
        {
            Console.WriteLine("Назва машини для видалення:");
            string name = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.Name == name);
            if (car == null)
            {
                Console.WriteLine("Error");
                return;
            }
            cars.Remove(car);
            Console.WriteLine($"Car is deleted {car.Name}");
        }
        public void ChoiceCarToName()
        {
            Console.WriteLine("Назва машини:");
            string name = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.Name == name);
            if (car == null) Console.WriteLine("Error");
            else
                Console.WriteLine($"Name: {car.Name}\tColor: {car.Color}\tSpeed: {car.Speed}");

        }
        public void ChoiceCarToSpeed()
        {
            Console.WriteLine("Швидкість:");
            string speed = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.Speed == Convert.ToInt32(speed));
            if (car == null) Console.WriteLine("Error");
            else
                Console.WriteLine($"Name: {car.Name}\tColor: {car.Color}\tSpeed: {car.Speed}");
        }
        public void ChoiceCarToYearProduction()
        {
            Console.WriteLine("Рік випуску машини:");
            string year = Console.ReadLine();
            var car = cars.FirstOrDefault(d => d.YearOfProdaction == year);
            if (car == null)
            {
                Console.WriteLine("Error");
                return;
            }
            else
                Console.WriteLine($"Name: {car.Name}\tColor: {car.Color}\tSpeed: {car.Speed}");
        }
    }
}
