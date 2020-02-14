using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Person
    {
        // Properties //
        public Person()
        {
            this.Address = new Address();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public int PhoneNumber { get; set; }
    }
}
