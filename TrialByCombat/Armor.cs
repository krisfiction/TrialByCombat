using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    public class Armor : Equipment
    {
        public int ArmorLow { get; set; }
        public int ArmorHigh { get; set; }
        public int ArmorClass { get; set; }

        public void ArmorAddToInventory()
        {
            Inventory.Inventories.Add(new Inventory(Type, Name, Description, Slot, Gold, PrefixName, PrefixStat, PrefixValue, SuffixName, SuffixStat, SuffixValue, ArmorClass));
        }

        public static int ArmorRoll(int ArmorLow, int ArmorHigh)
        {
            Random rand = new Random();
            return rand.Next(ArmorLow, ArmorHigh + 1);
        }
    }
}
