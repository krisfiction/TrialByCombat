using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class BastardSword : Weapon
    {
        public BastardSword(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Bastard Sword";
            Description = "a bastard sword";
            Slot = "Main Hand";
            Gold = 1000;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 6;
            DamageHigh = 15;
        }
    }
}