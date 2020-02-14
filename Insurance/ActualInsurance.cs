using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    /*Komodo Insurance needs a program that will allow to easily track their 
         * 
         * customers. 
               unique customer id number, 
               last name, 
               age, 
               enrollment date, and n
               umber of years using Komodo Insurance.


        store and manipulate our customers on a list => Customer Repository

        KI also requires that any methods built are unit tested.

        We also want to send a message to customers based on their years of subscribing. => Repository Method
            If they’ve been part of a plan for 1-5 years, we send them a thank you note. 
            If they have been a customer for more than 5 years, we send them a note that says: “Thank you for being a Gold member.”

        Write unit tests to ensure your methods are working properly and use the repository pattern.*/

            // My Code will be in comments if not correct //

    public class Customer
    {
        //public Customer() { }
        //public Customer(int NumberID, string LastName, DateTime BirthDate, DateTime StartDate) { }
        public int NumberID { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age 
        {
            get
            {
                TimeSpan  lifeSpan = DateTime.Now - BirthDate;
                double yearsDouble = lifeSpan.Days / 365.25;
                int years = Convert.ToInt32(Math.Floor(yearsDouble));
                return years;
            }
        }
        public DateTime StartDate { get; set; }
        public int YearsUsing
        {
            get
            {
                TimeSpan usingSpan = DateTime.Now - StartDate;
                double yearsDouble = usingSpan.Days / 365.25;
                int years = Convert.ToInt32(Math.Floor(yearsDouble));
                return years;
            }
        }
    }
}
