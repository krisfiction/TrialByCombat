using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class LongSword : Weapon
    {
        public LongSword(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Long Sword";
            Description = "a long sword";
            Slot = "Main Hand";
            Gold = 350;

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