using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    class CountryMusicSingerLegs : Legs
    {
        // constructor
        public CountryMusicSingerLegs(string clothing, bool isShaved) : base(clothing, "boots", isShaved)
        { }

        // methods
        public override void Dance()
        {
            Console.WriteLine("Country music singer legs do a square dance.");
        }
    }
}
