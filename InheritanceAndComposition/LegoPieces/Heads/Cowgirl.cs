using System;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class Cowgirl : Head
    {
        // properties
        public bool HasHat { get; set; }
        public LipstickColor LipstickColor { get; set; }


        // methods
        public void HairFlip()
        {
            Console.WriteLine($"The cowgirl flips her {HairColor} hiar. She doesn't even care.");
        }

        public override void Greet()
        {
            Console.WriteLine("Howdy!");
        }

        public void Eat()
        {
            Console.WriteLine($"The cowgirl eats her beans from a tin can.");
        }
    }
}
