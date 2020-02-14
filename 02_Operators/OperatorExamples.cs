using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class OperatorExamples
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 23;
            int b = 25;

            int sum = a + b;
            Console.WriteLine(sum);

            int difference = a - b;
            Console.WriteLine(difference);

            int product = a * b;
            Console.WriteLine(product);

            int quotient = a / b;
            Console.WriteLine(quotient);

            // double quotient = (double)a / (double)b; //
            // Console.WriteLine(quotient); //
            // This will show the decimal //

            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1978,1,1);
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan.Days);
        }
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 67;
            string username = "Doggo";
            bool equals = age == 41;
            bool userIsAdam = username == "Adam";
            Console.WriteLine("User is 41: " + equals);
            Console.WriteLine("User is Adam: " + userIsAdam);

            bool notEqual = age != 122;
            bool userIsNotJustin = username != "Justin";
            Console.WriteLine("User is not 122: " + notEqual);
            Console.WriteLine("User is not Justin: " + userIsNotJustin);

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool listAreEqual = firstList == secondList;
            Console.WriteLine("Are lists equal: " + listAreEqual);

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 24;
            bool lessThan = age < 68;
            bool lessThanOrEqual = age <= 67;
            Console.WriteLine("Is age greater than 12: " + greaterThan);
            Console.WriteLine("Is age greater than or equal to 24: " + greaterThanOrEqual);
            Console.WriteLine("Is age less than 68: " + lessThan);
            Console.WriteLine("Is age less than or equal to 67: " + lessThanOrEqual);

            bool orValue = equals || lessThan;

            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false;
            Console.WriteLine($"True or True: {tOrT}");
            Console.WriteLine($"True or False: {tOrF}");
            Console.WriteLine($"False or True: {fOrT}");
            Console.WriteLine($"False or False: {fOrF}");
            // Asking if either of the statements are true //
            // If any are true the statement will return true.  All have to be false for statement to return false //

            bool tAndT = true && true;
            bool tAndF = true && false;
            bool fAndT = false && true;
            bool fAndF = false && false;
            Console.WriteLine($"True and True: {tAndT}");
            Console.WriteLine($"True and False: {tAndF}");
            Console.WriteLine($"False and True: {fAndT}");
            Console.WriteLine($"False and False: {fAndF}");
            // Asking if both statements are true //
            // If any of the options are false statement will return false.  All have to be true to return true //
        }
    }
}
