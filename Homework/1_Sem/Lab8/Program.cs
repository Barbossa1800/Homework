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
            Garage garage = new Garage();
            int value = default;
            while (true)
            {
                Console.WriteLine("1)Вибір за назвою\t2)Вибір за швидкістью\t3)Вибір за рокому випуску\t4)Видалити машину за назвою");
                Console.Write("Ваш вибір: ");
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        garage.ChoiceCarToName();
                        break;
                    case 2:
                        garage.ChoiceCarToSpeed();
                        break;
                    case 3:
                        garage.ChoiceCarToYearProduction();
                        break;
                    case 4:
                        garage.RemoveCar();
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }
    }
}
