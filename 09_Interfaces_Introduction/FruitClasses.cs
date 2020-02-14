using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction
{
    public class Apple : IFruit
    {
        public Apple() { }
        public Apple(bool isPeeled)
        {
            Peeled = isPeeled;
        }
        public string Name { get { return "Apple"; } }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            Peeled = true;
            return "You peel the Apple";
        }
    }
    public class Orange : IFruit
    {
        public Orange() { }
        public Orange(bool isPeeled)
        {
            Peeled = isPeeled;
        }
        public string Name { get { return "Apple"; } }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            Peeled = true;
            return "You peel the Apple";
        }
        public string Zest()
        {
            if (Peeled)
            {
                return "Unable to zest a peeled orange";
            }
            return "You are zesting the orange for flavor";
        }
    }
    public class Grape : IFruit
    {
        public string Name
        {
            get { return "Grape"; }
        }

        public bool Peeled { get; private set; }

        public string Peel()
        {
            Peeled = true;
            return "Who peels grapes?";
        }
    }
}
