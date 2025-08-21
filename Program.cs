using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_cs
{
    /// <summary>
    /// Inheritance Example:
    /// Demonstrates how multiple child classes (Car, Bicycle, Boat)
    /// inherit shared members (like Speed and Go method) from a common base class (Vehicle).
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creating instances of different vehicle types
                Car car = new Car();
                Bicycle bicycle = new Bicycle();
                Boat boat = new Boat();

                // Displaying car details
                Console.WriteLine($"CAR SPEED: {car.Speed}");
                Console.WriteLine($"CAR WHEEL(S): {car.Wheels}");
                car.Go();

                // Displaying bicycle details
                Console.WriteLine($"\nBICYCLE SPEED: {bicycle.Speed}");
                Console.WriteLine($"BICYCLE WHEEL(S): {bicycle.Wheels}");
                bicycle.Go();

                // Displaying boat details
                Console.WriteLine($"\nBOAT SPEED: {boat.Speed}");
                Console.WriteLine($"BOAT WHEEL(S): {boat.Wheels}");
                boat.Go();
            }
            catch (Exception Issue)
            {
                // Error handling
                Console.WriteLine($"[ERROR]: {Issue.Message}");
            }
        }
    }

    /// <summary>
    /// Base class for all vehicle types.
    /// Contains common properties and methods shared by all vehicles.
    /// </summary>
    class Vehicle
    {
        // Default speed of a vehicle
        public int Speed = 0;

        // Method to simulate movement
        public void Go()
        {
            Console.WriteLine("This vehicle is moving.");
        }
    }

    /// <summary>
    /// Represents a car, inheriting from Vehicle.
    /// Adds specific property: number of wheels (4).
    /// </summary>
    class Car : Vehicle
    {
        public int Wheels = 4;
    }

    /// <summary>
    /// Represents a bicycle, inheriting from Vehicle.
    /// Adds specific property: number of wheels (2).
    /// </summary>
    class Bicycle : Vehicle
    {
        public int Wheels = 2;
    }

    /// <summary>
    /// Represents a boat, inheriting from Vehicle.
    /// Adds specific property: number of wheels (0).
    /// </summary>
    class Boat : Vehicle
    {
        public int Wheels = 0;
    }
}
