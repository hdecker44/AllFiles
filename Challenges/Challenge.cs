using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
    [TestClass]
    public class SlackChallenge
    {
        [TestMethod]
        public void Composite()
        {
            string name = "Henry";
            string product = "stereo";
            string location = "Westfield";
            string color = "gold";

            string welcome = string.Format("Hello {0}, welcome to ElevenFifty!  Your name is {0} right?  Are you from {1}? Do you have a {2} ticket?", name, location, color);
            Console.WriteLine(welcome);

            string spam = string.Format("You just won a {1} {0}!!!  Because you were the 1,000,000 customer we are rewarding you with a free {0}!", product, color);
            Console.WriteLine(spam);

            string random = string.Format("{0} is in the 30th percentile for {1} imports in the United States.  {0} imported 1,200 pounds of {1} this year.", location, color);
            Console.WriteLine(random);
        }
        [TestMethod]
        public void Interpolation()
        {
            string cheese = "string cheese";
            string pasta = "mac and cheese";
            string beans = "kidney beans";

            string breakfast = string.Format($"For breakfast I ate {cheese}, beans, and more {cheese}.");
            Console.WriteLine(breakfast);

            string lunch = string.Format($"For lunch I had {beans}, beans, and kidneys.  Oh did I mention {beans}?");
            Console.WriteLine(lunch);

            string dinner = string.Format($"For dinner I ate {pasta} with Mac.  Mac added more cheese and I added more mac.");
            Console.WriteLine(dinner);
        }
        [TestMethod]
        public void Concatenate_All()
        {
            string variable = "Hello";

            string concatenate = variable + " world, and " + variable + " class. Welcome to the gold badge.";
            Console.WriteLine(concatenate);

            string composite = string.Format("{0} world, and {0} class. Welcome to the gold badge.", variable);
            Console.WriteLine(composite);

            string interpolate = string.Format($"{variable} world, and {variable} class.  Welcome to the gold badge.");
            Console.WriteLine(interpolate);
        }
        [TestMethod]
        public void Collections()
        {
            string[] letters = { "H", "D", "R", "Z", "B" };
            Console.WriteLine(letters[2]);

            List<string> fruits = new List<string>();

            fruits.Add("Blueberries");
            fruits.Add("Pineapple");
            fruits.Add("Pear");
            fruits.Add("Apple");
            fruits.Add("Strawberry");
            fruits.Add("Grape");
            fruits.Sort();
        }
        [TestMethod]
        public void IfStatements()
        {
            int sleep = 9;

            if (sleep < 8)
            {
                Console.WriteLine("I slept less than eight hours.  I am tired.");
            }
            if (sleep > 20) ;
            {
                Console.WriteLine("I slept more than twenty hours.  I might be in a coma.");
            }
        }
        [TestMethod]
        public void SwitchCase()
        {
            string input = "Gryffindor";
            switch (input)
            {
                case "Gryffindor":
                    Console.WriteLine("Welcome to Gryffindor!");
                    break;
                case "Slytherin":
                    Console.WriteLine("Welcome to Slytherin!");
                    break;
                case "Hufflepuff":
                    Console.WriteLine("Welcome to Hufflepuff!");
                    break;
                case "Ravenclaw":
                    Console.WriteLine("Welcome to Ravenclaw!");
                    break;
                default:
                    Console.WriteLine("Welcome to Hogwarts!");
                    break;
            }
        }
        [TestMethod]
        public void Ternaries()
        {
            int volumeLevel = 3;
            string volume = (volumeLevel > 5) ? "Turn it down" : "Turn it up";
            Console.WriteLine(volume);

            bool canSee = true;
            bool lightOn = (canSee == true) ? false : true; 
            if (lightOn)
            {
                Console.WriteLine("Turn the light on.");
            }
            else
            {
                Console.WriteLine("Keep the light off.");
            }

            
        }
        [TestMethod]
        public void CheckSquareFootage()
        {
            Room classRoom = new Room();
            classRoom.Length = 10;
            classRoom.Width = 15;
            classRoom.Height = 8;

            double squareFootage = classRoom.CalculateSquareFootage();

            Console.WriteLine($"Actual Square Footage: {squareFootage} square feet.");

            Assert.AreEqual(150d, squareFootage);
        }
        [TestMethod]
        public void CheckSquareFootageFraction()
        {
            Room myRoom = new Room();
        
            myRoom.Length = 10;
            myRoom.Width = 10;

            int denominator = 2;

            double actual = myRoom.CalculateSquareFootage(denominator);
            double expected = myRoom.Length * myRoom.Width / denominator;

            Assert.AreEqual(expected, actual);
        }

    }
}
