using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int EmailID { get; set; }
        public int YearsOfService
        {
            get
            {
                TimeSpan timeServed = DateTime.Now - HireDate;
                double yearsDouble = timeServed.Days / 365.25;
                int years = Convert.ToInt32(Math.Floor(yearsDouble));
                return years;
            }
        }
    }
    public class HourlyEmployee : Employee
    {
        public decimal Wage { get; set; }
        public double Hours { get; set; }
    }
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
    }
}
