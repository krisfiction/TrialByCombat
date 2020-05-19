using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    public class Items // every item in game
    {
        public string Type { get; set; } // Armor, Weapon, Potion, Scroll
        public string Name { get; set; } // Name of the item
        public string Description { get; set; } // Short description of item
        public string Slot { get; set; } // Body Slot (Head, Feet, Legs, Chest, etc..), Inventory, Potion Belt
        public int Gold { get; set; } // Gold
        //public int Weight { get; set; }  // Weight of item - not currently used

        public static int Roll(int Low, int High)
        {
            Random rand = new Random();
            return rand.Next(Low, High + 1);
        }
    }
}