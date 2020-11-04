using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Independent_work
{
    public class ProductAvailability
    {
        List<Liquor> liquor => new List<Liquor>()
        { 
            new Liquor(){Name = "Frangelico", Country = "Italy", Cost = 400, Eendurance = 28, Producer = "BArbero", Valuee = 1},
            new Liquor(){Name = "Galliano ", Country = "Italy", Cost = 780,  Eendurance = 35, Producer = "Baboo", Valuee = 0.75},
            new Liquor(){Name = "Chartreuse  ", Country = "England", Cost = 400, Eendurance = 20, Producer = "Lolomento", Valuee = 2},
            new Liquor(){Name = "Drambuie   ", Country = "Scotland", Cost = 900, Eendurance = 35, Producer = "Damboo", Valuee = 2.5}
        };
        public void Request(string Name, string Country, double Cost, int Eendurance, string Producer, double Valuee=0)
        {
            var liquers = liquor.Where(d => d.Name.Contains(Name) && d.Country.Contains(Country) && d.Cost == Cost && d.Eendurance == Eendurance
              && d.Producer.Contains(Producer) && d.Valuee==Valuee);
            if (liquers == null )
            {
                Console.WriteLine("Товаров нет в наличии!");
                return;
            }
            else
            {
                foreach (var item in liquers)
                {
                    Console.WriteLine($"Вам подходит: {item.Name}");
                }
            }
        }
        public void Request(string Country, int Eendurance, string Producer)
        {
            var liquers = liquor.Where(d => d.Country == Country && d.Eendurance == Eendurance && d.Producer == Producer);
            if (liquers == null)
            {
                Console.WriteLine("Товаров нет в наличии!");
                return;
            }
            else
            {
                foreach (var item in liquers)
                {
                    Console.WriteLine($"Вам подходит: {item.Name}");
                }
            }
        }
    }
}
