﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    class CyclistLegs : Legs
    {
        // constructor
        public CyclistLegs() : base("bike shorts", "cycling shoes", true)
        { }

        // methods
        public override void Dance()
        {
            Console.WriteLine("Too busy biking to dance.");
        }
    }
}
