using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;
        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt.");
        }
        [TestInitialize]
        public void Arrange()
        {
            _debt = 9080.30m;
        }
        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(450m));
            decimal expectedDebt = 9080.30m - 451m;
            Assert.AreEqual(expectedDebt, _debt);
        }
        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();
            var electronicPayment = new ElectronicPayment(123.4m);
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(electronicPayment);
            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());
            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());

            Assert.AreEqual(123.4m, secondTransaction.GetAmount());
        }
        [TestMethod]
        public void MoreExamples()
        {
            var list = new List<Transaction>
            {
                new Transaction(new Dollar()),
                new Transaction(new ElectronicPayment(231.95m)),
                new Transaction(new Penny()),
                new Transaction(new Nickel())
                 
            };

            foreach(var transaction in list)
            {
                var type = transaction.GetTransactionType();
                var amount = transaction.GetAmount();
                Console.WriteLine($"{type} ${amount} {transaction.DateOfTransaction}");
            }
        }
        public void Change()
        {/* Define payment types:
            penny, nickel, dime, quarter, dollar, five dollar, ten dollar, twenty dollar, fifty dollar, hundred dollar*/

            decimal penny = .01m;
            decimal nickel = .05m;
            decimal dime = .1m;
            decimal quarter = .25m;
            decimal dollar = 1m;
            decimal five = 5m;
            decimal ten = 10m;
            decimal twenty = 20m;
            decimal fifty = 50m;
            decimal hundred = 100m;

            decimal cost = 227.88m;
            decimal rB = cost;
            decimal remainder;

            if (rB >= hundred)
            {
                remainder = rB % hundred;
                decimal num100 = rB / hundred;
                num100 = Math.Floor(num100);

                if (rB >= fifty)
                {
                    remainder = rB % fifty;
                    decimal num50 = rB / fifty;
                    num50 = Math.Floor(num50);

                    if (rB >= twenty)
                    {
                        remainder = rB % twenty;
                        decimal num20 = rB / twenty;
                        num20 = Math.Floor(num20);

                        if(rB >= ten)
                        {
                            remainder = rB % ten;
                            decimal num10 = rB / ten;
                            num10 = Math.Floor(num10);
                        }
                    }
                }
                else
                {

                }
            }
            else
            {
                remainder = rB % fifty;
                decimal num50 = rB / fifty;
                num50 = Math.Floor(num50);

                if 
            }
                

                    
        }
    }
}
