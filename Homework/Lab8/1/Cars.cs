using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8._1
{
    public class Cars
    {

        private string id = new Guid().ToString();
        private string nameOfCar { get; set; }
        private string colorCar { get; set; }
        private string yearOfCarProduction { get; set; }
        public string Id => id;
        public Cars(string nameOfCar, string colorCar, string yearOfCarProduction)
        {
            this.nameOfCar = nameOfCar;
            this.colorCar = colorCar;
            this.yearOfCarProduction = yearOfCarProduction;
        }
    }
}
