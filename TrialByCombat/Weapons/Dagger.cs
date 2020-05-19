using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class Dagger : Weapon
    {
        public Dagger(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Dagger";
            Description = "a dagger";
            Slot = "Main Hand";
            Gold = 60;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 1;
            DamageHigh = 4;
        }
    }
}