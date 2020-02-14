using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void SetAddress()
        {
            Person mike = new Person();
            mike.Address.StreetName = "Fake Street";
            mike.Address.HouseNumber = "123";
            mike.Address.City = "Westfield";
            mike.Address.State = "Indiana";
            mike.Address.ZipCode = "46074";

            Console.WriteLine(mike.Address.ToString());

            Customer julie = new Customer();
            julie.Address.StreetName = "North Fake Street";
            julie.Address.HouseNumber = "456";
            julie.Address.City = "Westfield";
            julie.Address.State = "Indiana";
            julie.Address.ZipCode = "46074";

            Console.WriteLine(julie.Address.ToString());
        }

        [TestMethod]
        public void CustomerIsPremium()
        {
            Customer kevin = new Customer();
            kevin.IsPremium = true;

            Console.WriteLine(kevin.IsPremium);
            Console.WriteLine(kevin.GetType());
        }
        [TestMethod]
        public void EmployeeTests()
        {
            Employee julian = new Employee();
            HourlyEmployee bubbles = new HourlyEmployee();
            SalaryEmployee ricky = new SalaryEmployee();

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(julian);
            allEmployees.Add(bubbles);
            allEmployees.Add(ricky);

            //var employee = allEmployees[1];

            foreach (Employee worker in allEmployees)
            {
                if(worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;
                    Console.WriteLine($"This is a salary employee that makes {sEmployee.Salary}.");
                }
                else if (worker is HourlyEmployee hourlyWorker)
                {
                    HourlyEmployee hEmployee = (HourlyEmployee)worker;
                    Console.WriteLine(hourlyWorker.Hours);
                }
                /* Abstraction
                 * Polymorphism
                 * Inheritance - one class recieving the traits/properties of another class (hourlyEmployee and Employee)
                 * Encapsulation
                 */
            }
        }
    }
}
