using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    abstract class Legs
    {
        // properties
        public string Clothing { get; }
        public string Shoes { get; }
        public bool IsShaved { get; }

        // constructor
        protected Legs(string clothing, string shoes, bool isShaved)
        {
            Clothing = clothing;
            Shoes = shoes;
            IsShaved = isShaved;
        }

        // methods
        public void Walk(int numOfSteps)
        {
            Console.WriteLine($"The legs wearing {Clothing} walked {numOfSteps} steps in {Shoes}.");
        }

        public void Kick()
        {
            Console.WriteLine("The legs kicked vigorously.");
        }

        public abstract void Dance();
    }
}
