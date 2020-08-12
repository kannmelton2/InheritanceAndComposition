using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Torsos
{
    class FarmerTorso : Torso
    {
        // type ctor tab-tab to build constructor automatically
        public FarmerTorso(Sex sex)
        {
            // Farmers will always have red plaid shirt, garden hoe and strong arms
            Clothing = "Red Plaid Shirt";
            Accessory = "Garden Hoe";
            ArmType = ArmType.Strong;
            // The sex is set when instaniated
            Sex = sex;
        }
    }
}
