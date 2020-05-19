using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class SmallAxe : Weapon
    {
        public SmallAxe(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Small Axe";
            Description = "a small axe";
            Slot = "Main Hand";
            Gold = 150;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 2;
            DamageHigh = 10;
        }
    }
}