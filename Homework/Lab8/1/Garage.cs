using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8._1
{
    public class Garage
    {
        private string sheikhsName;
        private List<Cars> cars;

        public string NameOfSheikhs => sheikhsName;

        public List<Cars> GetAllCars() => cars;
        public List<Cars> GetCarsByBrand(string brand) => cars.Where(d => d.Brand == brand).ToList();
        public List<Cars> GetCarsByModel(string model) => cars.Where(d => d.Model == model).ToList();
        public List<Cars> GetCarsByColor(string color) => cars.Where(d => d.Color == color).ToList();
        public void AddCar(Cars car) => cars.Add(car);
        
        public void ShowCars(List<Cars> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public Garage(string Name, List<Cars> cars)
        {
            sheikhsName = Name;
            this.cars = cars;
        }
    }
}
