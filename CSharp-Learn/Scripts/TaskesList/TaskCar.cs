using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.TaskesList
{
    class TaskCar
    {
        public void ListCar()
        {
            List<Car> Cars = new List<Car>();

            Car car = new Car();

            car.Marka = "Lada (ВАЗ)";
            car.Model = 21093;
            car.EntryYear = 2002;

            Cars.Add(car);

            car.Greet();
        }
    }

    class Car
    {
        public string Marka { get; set; }
        public int Model { get; set; }
        public int EntryYear { get; set; }
        public void Greet()
        {
            Console.WriteLine($"Марка машины: {Marka}. Модель: {Model}. Год выпуска: {EntryYear}.");
        }
    }
}
