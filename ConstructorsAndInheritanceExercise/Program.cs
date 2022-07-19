using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2243566#content
namespace ConstructorsAndInheritanceExercise
{
    public class Vehicle
    {
        public string RegistrationNumber { get; }
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}
        public Vehicle(string registrationNumber)
        {
            RegistrationNumber = registrationNumber;
            Console.WriteLine($"Vehicle is being initialized. {registrationNumber}");
        }

    }
    public class Car : Vehicle
    {
        //if you create an object of type Car, the runtime tries to create
        //an object of type Vehicle, and since the Vehicle type doesn't have a
        //parameterless constructor the runtime doesn't know how to create an object
        //of type Vehicle - this is why you need to use base keyword
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine($"Car is being initialized. {registrationNumber}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // the constructor of the base class is always executed first
            var car = new Car("DADA539432");
        }
    }
}