using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, Plane, Boat, Bike, Spaceship, Train }
    class Vehicle
    {
        public Vehicle ()
        {
            BodyColor = "Magenta";
        }

        public Vehicle(string make, string model, double mileage, string bodyColor, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            BodyColor = bodyColor;
            TypeOfVehicle = type;
        }


        public string BodyColor { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get
            {
                //if (FirstName == null && LastName == null)
                string fullName = $"{FirstName} {LastName}";
                if (string.IsNullOrWhiteSpace(fullName))
                {
                    return "Unnamed";
                }
                return fullName;
            }
        }

        public DateTime DOB { get; set; }

        public int Age
        {
            get
            {
                if (DOB == new DateTime())
                {
                    return -2;
                }

                TimeSpan ageSpan = DateTime.Now - DOB;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                double floorAge = Math.Floor(totalAgeInYears);
                int years = Convert.ToInt32(floorAge);
                //int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return years;
            }
        }
    }
}

