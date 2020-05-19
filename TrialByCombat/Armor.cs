using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    public class Armor : Equipment
    {
        public int ArmorLow { get; set; } // base low armor
        public int ArmorHigh { get; set; } // base high armor
        public int ArmorClass { get; set; } // the randdom value of Low and High

        public void ArmorAddToInventory()
        {
            Inventory.Inventories.Add(new Inventory(Type, Name, Description, Slot, Gold, PrefixName, PrefixStat, PrefixValue, SuffixName, SuffixStat, SuffixValue, ArmorClass));
        }
    }
}
