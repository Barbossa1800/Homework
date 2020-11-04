using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8._1
{
    public class Cars
    {

        private string id = Guid.NewGuid().ToString();
        private string brand;
        private string model;
        private string color;

        public string Id => id;
        public string Brand => brand;
        public string Model => model;
        public string Color => color;
        public Cars(string brand, string model, string color)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
        }
        public override string ToString()
        {
            return $"Brand: {brand}, Model: {model}, Color: {color}";
        }
    }
}
