using InheritanceAndComposition.LegoPieces.Heads;
using System;
using System.Collections.Generic;

namespace InheritanceAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            // by defining these heads as "Head", you lose access to anything the inheriting classes don't share
            // so astro doesn't have any access to the Observe method,
            // nor can the cowgirl flip her hair
            // neither can the pirate sing
            Head astro = new AstronautHead();
            Head pirateHead = new PirateHead();
            Head cowgirlHead = new Cowgirl();


            cowgirlHead.Greet();
            pirateHead.Greet();
            astro.Greet();

            var majorTom = new AstronautHead();
            var capnJack = new PirateHead();
            var jessy = new Cowgirl();

            majorTom.HairColor = HairColor.Blonde;
            majorTom.EyeColor = EyeColor.Gray;

            capnJack.HairColor = HairColor.Brown;
            capnJack.EyeColor = EyeColor.Brown;

            jessy.HairColor = HairColor.Red;
            jessy.EyeColor = EyeColor.Blue;

            var heads = new List<Head>();
            heads.Add(capnJack);
            heads.Add(jessy);
            heads.Add(majorTom);

            // again, they are being defined as Heads, so you can only access 
            // shared things - hair color, eye color, and the greet method.
            foreach (var head in heads)
            {
                Console.WriteLine($"The {head.HairColor} headed, {head.EyeColor} eyed head is greeting you...");
                head.Greet();
            }

            
        }
    }
}
