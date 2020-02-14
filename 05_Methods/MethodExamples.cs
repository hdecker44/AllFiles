using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {//Access Modifier //Return Type //Signature: Name(Parameters)
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public int Multiply( int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }

        public double Add(double numberOne, double numberTwo)
        {
            double sum = numberOne + numberTwo;
            return sum;
        }

        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            double floorAge = Math.Floor(totalAgeInYears);
            int years = Convert.ToInt32(floorAge);
            //int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }

        [TestMethod]
        public void MethodExecution()
        {
            SayHello("George");
            SayHello("Josh");

            int total = Add(23, 86);
            Console.WriteLine(total);

            int total2 = Multiply(23, 86);
            Console.WriteLine(total2);
            var another = Add(1, 6);
            DateTime birthdate = new DateTime(1944, 12, 24);
            Console.WriteLine(CalculateAge(birthdate));
        }
    }
}
