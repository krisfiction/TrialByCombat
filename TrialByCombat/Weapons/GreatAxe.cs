using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class GreatAxe : Weapon
    {
        public GreatAxe(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Great Axe";
            Description = "a great axe";
            Slot = "Main Hand";
            Gold = 2500;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 12;
            DamageHigh = 30;
        }
    }
}