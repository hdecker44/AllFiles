using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {
            Vehicle airplane = new Vehicle();
            airplane.BodyColor = "Hot Pink";
            airplane.Make = "Boeing";
            airplane.Model = "737 Max";
            airplane.Mileage = 0.1;

            Console.WriteLine(airplane.Make + " " + airplane.Model);

            airplane.TypeOfVehicle = VehicleType.Plane;

            Vehicle myCar = new Vehicle();
            myCar.BodyColor = "Silver";
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Mileage = 35000.01;
            myCar.TypeOfVehicle = VehicleType.Car;

            Vehicle anotherCar = new Vehicle("Honda", "Pilot", 144000, "Aqua", VehicleType.Car);

            Console.WriteLine(anotherCar.Make + " " + anotherCar.Model);
        }

        [TestMethod]
        public void PersonTest()
        {
            Person firstPerson = new Person();
            firstPerson.FirstName = "Brian";
            firstPerson.LastName = "Wilson";
            firstPerson.DOB = new DateTime(1990, 8, 19);
            Console.WriteLine(firstPerson.FullName);
            Console.WriteLine($"{firstPerson.FullName} is {firstPerson.Age} years old");

            Person blankPerson = new Person();
            Console.WriteLine("Blank name: " + blankPerson.FullName);
            Console.WriteLine($"{blankPerson.FullName} is {blankPerson.Age} years old");
        }
    }   
}
