using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19._12._17
{
    struct Car
    {
        public string Name;
        public int Year;
        public int Price;
        public int Capacity;

        public override string ToString()
        {
            return String.Format($"     {Name,10}|      {Year,4}|     {Price,7}|        {Capacity,3}|");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>
            {
                new Car { Name = "BMW", Capacity = 66, Price = 200000, Year = 2005 },
                new Car { Name = "Toyota", Capacity = 70, Price = 120000, Year = 2001 },
                new Car { Name = "Mercedes", Capacity = 80, Price = 300000, Year = 2011 },
                new Car { Name = "Porche", Capacity = 60, Price = 450000, Year = 2014 },
            };

            Car newcar = new Car();
            Console.Write("Please, enter a name of a new car:");
            newcar.Name = Console.ReadLine();
            Console.Write("Please, enter a fuel capacity of a new car:");
            newcar.Capacity = int.Parse(Console.ReadLine());
            Console.Write("Please, enter a year of manufacturing of a new car:");
            newcar.Year = int.Parse(Console.ReadLine());
            Console.Write("Please, enter a price of a new car:");
            newcar.Price = int.Parse(Console.ReadLine());

            Cars.Add(newcar);

            Car tempcar;
            for (int i = 0; i < Cars.Count; i++)
            {
                for (int j = 0; j < Cars.Count-1; j++)
                {
                    if (Cars[j].Price > Cars[j + 1].Price)
                    {
                        tempcar = Cars[j];
                        Cars[j] = Cars[j + 1];
                        Cars[j + 1] = tempcar;
                    }

                }
            }

            foreach (var item in Cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
