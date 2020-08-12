using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Torsos
{
    // marking class as abstract means it cannot be directly instantiated
    // it's just an idea of a class, until it is acted upon by an
    // inheriting class
    abstract class Torso
    {
        // properties
        public ArmType ArmType { get; set; }
        public string Clothing { get; protected set; }
        public string Accessory { get; set; }
        public Sex Sex { get; set; }

        // methods
        public virtual void Wave()
        {
            Console.WriteLine($"Waves hello with their {ArmType} arm.");
        }

        public void PickUp(string heavyObject)
        {
            if (IsStrong())
            {
                Console.WriteLine($"I used by strong arms to pick up the {heavyObject}.");
            }
            else
            {
                Console.WriteLine($"My {ArmType} arms cannot pick up the {heavyObject}.");
            }
        }

        protected virtual bool IsStrong()
        {
            return ArmType == ArmType.Strong;
        }
    }
    enum ArmType
    {
        Skinny,
        Strong,
        Baby,
        Dinosaur
    }

    enum Sex
    {
        Unknown,
        Male,
        Female,
        Other
    }
}
