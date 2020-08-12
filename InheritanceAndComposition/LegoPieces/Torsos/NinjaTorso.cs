using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Torsos
{
    class NinjaTorso : Torso
    {
        // properties
        public string Weapon { get; set; }

        // constructor
        public NinjaTorso()
        {
            Clothing = "Black ninja-yoroi";
            Accessory = "Red Cape";
            ArmType = ArmType.Strong;
            Sex = Sex.Unknown;
            Weapon = "Nunchaku";
        }

        // methods
        public override void Wave()
        {
            Console.WriteLine($"The ninja torso waves its {ArmType} arms silently to get your attention.");
        }

        protected override bool IsStrong()
        {
            return true;
        }
    }
}
