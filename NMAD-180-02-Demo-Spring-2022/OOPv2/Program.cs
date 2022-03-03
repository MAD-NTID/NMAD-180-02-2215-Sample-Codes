using System;

namespace OOPv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[2];

            for(int i = 0; i< cars.Length; i++)
            {
                Console.Write("Brand:");
                string brand = Console.ReadLine();
                Console.Write("Year:");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Doors:");
                int doors = int.Parse(Console.ReadLine());

                Car car = new Car();
                car.Brand = brand;
                car.Year = year;
                car.DoorNumbers = doors;

                cars[i] = car;
            }

            Console.WriteLine("\nCar info:");

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Brand} - {car.Year} - {car.DoorNumbers}");
            }


        }
    }
}
