using InheritanceAndComposition.LegoPieces.Heads;
using InheritanceAndComposition.LegoPieces.Legs;
using InheritanceAndComposition.LegoPieces.Torsos;
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
            Head pirate = new PirateHead();
            Head cowgirl = new CowgirlHead();


            cowgirl.Greet();
            pirate.Greet();
            astro.Greet();

            // by not directly defining these heads as "Head",
            // you have access to all the common "Head" things and
            // access to all the individual things,
            // but they are still "Head"s
            var astronautHead = new AstronautHead();
            var pirateHead = new PirateHead();
            var cowgirlHead = new CowgirlHead();

            astronautHead.HairColor = HairColor.Blonde;
            astronautHead.EyeColor = EyeColor.Gray;

            pirateHead.HairColor = HairColor.Brown;
            pirateHead.EyeColor = EyeColor.Brown;

            cowgirlHead.HairColor = HairColor.Red;
            cowgirlHead.EyeColor = EyeColor.Blue;

            var heads = new List<Head>();
            heads.Add(pirateHead);
            heads.Add(cowgirlHead);
            heads.Add(astronautHead);

            Console.WriteLine(new string('-', 50));

            // again, they are being defined as Heads, so you can only access 
            // shared things - hair color, eye color, and the greet method.
            foreach (var head in heads)
            {
                Console.WriteLine($"The {head.HairColor} haired, {head.EyeColor} eyed head is greeting you...");
                head.Greet();
            }

            var farmerTorso = new FarmerTorso(Sex.Male);
            var ninjaTorso = new NinjaTorso();

            farmerTorso.PickUp("goat in pjs");
            ninjaTorso.PickUp("Box");

            var cyclistLegs = new CyclistLegs();
            var countryMusicSingerLegs = new CountryMusicSingerLegs("blue jeans", false);

            var astronaut = new Minifigure("Major Tom", astronautHead, ninjaTorso, cyclistLegs);
            var cowgirlJessy = new Minifigure("Jessy", cowgirlHead, farmerTorso, countryMusicSingerLegs);

            cowgirlJessy.SayHello();
            astronaut.SayHello();
        }
    }
}
