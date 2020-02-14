using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Car
{
    class Sedan : ICar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool IsRunning { get; set; }

        public void Drive()
        {
            if (IsRunning)
            {
                Console.WriteLine("Your car is running");
            }
            else
            {
                Console.WriteLine("The car is off and cannot drive");
            }
        }
        public void Start()
        {
            if (IsRunning)
            {
                Console.WriteLine("Your car is already running!");
            }
            else
            {
                IsRunning = true;
                Console.WriteLine("Your car is now running");
            }
        }
        public void TurnOff()
        {
            if (IsRunning)
            {
                IsRunning = false;
                Console.WriteLine("Your car is no longer running");
            }
            else
            {
                Console.WriteLine("Your car is already off");
            }
        }
        public void Power()
        {
            if (IsRunning)
            {
                IsRunning = false;
                Console.WriteLine("Your car is no longer running");
            }
            else
            {
                IsRunning = true;
                Console.WriteLine("You car is now running");
            }
        }
    }
}
