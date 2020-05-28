using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    public class Weapon : Equipment
    {
        public int DamageLow { get; set; }
        public int DamageHigh { get; set; }

        public void WeaponAddToInventory()
        {
           Inventory.Inventories.Add(new Inventory(Type, Name, Description, Slot, Gold, PrefixName, PrefixStat, PrefixValue, SuffixName, SuffixStat, SuffixValue, DamageLow, DamageHigh));
        }

        //todo AddtoPLayer(); -- should be in inventory display() ??


        }
    }
}


