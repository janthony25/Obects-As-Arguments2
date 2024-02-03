using System;
using System.Data;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Lim", "Mazda", "2");
            Console.WriteLine($"{car1.owner} owns a {car1.carMake} {car1.carModel}");
            CarChange(car1, "3");
            Console.WriteLine($"{car1.owner} upgrades his car to {car1.carMake} {car1.carModel}");

            Car car2 = Copy(car1);
            Console.WriteLine($"Jun bought a new car that is also a {car2.carMake} {car2.carModel}");


            Console.ReadKey();
        }

        public static void CarChange(Car car, string carModel)
        {
            car.carModel = carModel;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.owner, car.carMake, car.carModel);
        }
    }

    class Car
    {
        public string owner;
        public string carMake;
        public string carModel;

        public Car(string owner, string carMake, string carModel)
        {
            this.owner = owner;
            this.carMake = carMake;
            this.carModel = carModel;
        }
    }
}