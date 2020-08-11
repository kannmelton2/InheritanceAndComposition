using System;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class PirateHead : Head
    {
        // properties
        public bool HasPatch { get; set; }
        public string FacialHair { get; set; }

        // methods
        public void Sing()
        {
            Console.WriteLine($"The {HairColor} haired pirate sang 'Yo ho ho and a bottle of rum' out of tune");
        }

        public void Laugh()
        {
            Console.WriteLine("Har Har Har.");
        }
    }
}
