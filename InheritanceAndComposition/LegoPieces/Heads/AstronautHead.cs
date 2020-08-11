using System;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class AstronautHead : Head
    {
        // properties
        public bool HasHelmet { get; set; } = true;
        public bool HasFreckles { get; set; }


        // methods
        // override keyword allows you to change the behavior of the base clas
        // that you are inheriting from
        // you cannot change the accessiblitiy modifiers, the return type or the parameters
        public override void Greet()
        {
            Console.WriteLine("Major Tom to Ground Control...");
            // base = allows you to talk to the class you are inheriting from
            base.Greet();
        }

        public void Observe()
        {
            Console.WriteLine("The astronaut sees everything all at once. Across time.");
        }
    }
}
