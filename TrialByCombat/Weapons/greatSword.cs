using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class GreatSword : Weapon
    {
        public GreatSword(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Great Sword";
            Description = "a great sword";
            Slot = "Main Hand";
            Gold = 3000;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 10;
            DamageHigh = 20;
        }
    }
}