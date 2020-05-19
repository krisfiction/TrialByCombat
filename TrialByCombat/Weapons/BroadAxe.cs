using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class BroadAxe : Weapon
    {
        public BroadAxe(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Broad Axe";
            Description = "a broad axe";
            Slot = "Main Hand";
            Gold = 1000;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 8;
            DamageHigh = 20;
        }
    }
}