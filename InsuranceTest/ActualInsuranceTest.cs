using System;
using Insurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsuranceTest
{
    [TestClass]
    public class ActualInsuranceTest
    {
        [TestMethod]
        public void SetPerson()
        {
            Customer ricky = new Customer(123,"TPB", new DateTime(1990,10,10), new DateTime(2018,10,10));
            Customer julian = new Customer(124, "Lahey", new DateTime(1991, 4, 9), new DateTime(2015, 1, 1));
            Customer bubbles = new Customer(125, "Lahey", new DateTime(1994, 5, 10), new DateTime(2015, 3, 10));
        }
    }
}
