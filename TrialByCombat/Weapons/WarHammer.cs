using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class WarHammer : Weapon
    {
        public WarHammer(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "War Hammer";
            Description = "a war hammer";
            Slot = "Main Hand";
            Gold = 600;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 5;
            DamageHigh = 9;
        }
    }
}