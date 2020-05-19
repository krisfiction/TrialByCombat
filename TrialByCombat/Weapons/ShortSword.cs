using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class ShortSword : Weapon
    {
        public ShortSword(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Short Sword";
            Description = "a short sword";
            Slot = "Main Hand";
            Gold = 120;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 2;
            DamageHigh = 6;
        }
    }
}