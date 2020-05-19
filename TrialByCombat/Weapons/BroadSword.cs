using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class BroadSword : Weapon
    {
        public BroadSword(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Broad Sword";
            Description = "a broad sword";
            Slot = "Main Hand";
            Gold = 750;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 4;
            DamageHigh = 12;
        }
    }
}