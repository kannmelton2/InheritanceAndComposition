using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class Head
    {
        public EyeColor EyeColor { get; set; }
        public HairColor HairColor { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
