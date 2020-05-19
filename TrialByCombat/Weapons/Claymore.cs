using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class Claymore : Weapon
    {
        public Claymore(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Claymore";
            Description = "a claymore";
            Slot = "Main Hand";
            Gold = 450;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 1;
            DamageHigh = 12;
        }
    }
}
