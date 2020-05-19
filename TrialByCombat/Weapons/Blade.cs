using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class Blade : Weapon
    {
        public Blade(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Blade";
            Description = "a blade";
            Slot = "Main Hand";
            Gold = 280;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 3;
            DamageHigh = 8;
        }
    }
}