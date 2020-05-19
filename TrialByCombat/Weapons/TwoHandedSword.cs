using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class TwoHandedSword : Weapon
    {
        public TwoHandedSword(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Two-Handed Sword";
            Description = "a two-handed sword";
            Slot = "Main Hand";
            Gold = 1800;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 8;
            DamageHigh = 16;
        }
    }
}