using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Customer : Person
    // Customer inherits Person traits, but Person does not inherit Customer traits //
    {
        public bool IsPremium { get; set; }
    }
}
