using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void PennyTests()
        {
            ICurrency penny = new Penny();
            Assert.AreEqual(.01m, penny.Value);
            Assert.AreEqual("Penny", penny.Name);
        }
        [TestMethod]
        public void NickelTests()
        {
            ICurrency nickel = new Nickel();
            Assert.AreEqual(.05m, nickel.Value);
            Assert.AreEqual("Nickel", nickel.Name);
        }
        [TestMethod]
        public void DimeTests()
        {
            ICurrency dime = new Dime();
            Assert.AreEqual(.1m, dime.Value);
            Assert.AreEqual("Dime", dime.Name);
        }
        [TestMethod]
        public void QuarterTests()
        {
            ICurrency quarter = new Quarter();
            Assert.AreEqual(.25m, quarter.Value);
            Assert.AreEqual("Quarter", quarter.Name);
        }
        [TestMethod]
        public void DollarTestss()
        {
            ICurrency dollar = new Dollar();
            Assert.AreEqual(1m, dollar.Value);
            Assert.AreEqual("Dollar", dollar.Name);
        }
        [DataTestMethod]
        [DataRow(100.2)]
        [DataRow(37.12)]
        [DataRow(23.19)]
        [DataRow(2020.20)]
        [DataRow(1.98)]
        [DataRow(.08)]
        public void EPaymentTests(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertedValue);
            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }
    }
}
