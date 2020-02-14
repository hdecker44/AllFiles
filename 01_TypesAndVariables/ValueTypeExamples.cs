using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;
            bool isDeclarationAndInitialized = false;
            // use "is" at beginning of bool name//
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '&';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
            // char = one character //
            // \n works but /n does not; /n is new line //
        }
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 15;
            int b = 22;
            int c = 37;
            byte age = 254;
            // byte range 0 -> 255 //
            // sbyte range -128 -> 127 //
            // short range -32768 -> 32767 //
            // short = Int16 //
            // int range -2147483648 -> 2147483647 //
            // int = Int32 //
            // long range -9223372036854775808 -> 9223372036854775807 //
            // long = Int64 //
        }
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.2578907289045789789789789787897m;
            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
            // f needed after float value //
            // d not needed after double value; decimal number defaults to double //
            // m needed after decimal value //
        }
        enum PastryType { Cake, Danish, Donut, Scone, Cupcake, Croissant}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Donut;
            PastryType anotherOne = PastryType.Scone;
            Console.WriteLine(myPastry);
            Console.WriteLine(anotherOne);
        }
        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(2020, 11, 24);
            Console.WriteLine(birthday);
        }
        [TestMethod]
        public void Challenges()
        {
            byte kobe = 24;
            short weight;
            decimal height = 70.5m;
            DateTime bday = new DateTime(1998, 8, 4);
            char firstInitial = 'H';
            char lastInitial = 'D';
            DateTime today;
            float age;
        }
        enum Basketball { Stockton, Kobe, Jordan, Lebron, Shaq};
        [TestMethod]
        public void enumStartingFive()
        {
            Basketball pointGuard = Basketball.Stockton;
            Basketball center = Basketball.Shaq;
            Console.WriteLine(pointGuard);
            Console.WriteLine(center);
        }
    }
}
