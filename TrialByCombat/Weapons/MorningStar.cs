using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class MorningStar : Weapon
    {
        public MorningStar(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Morning Star";
            Description = "a morning star";
            Slot = "main Hand";
            Gold = 300;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 1;
            DamageHigh = 10;
        }
    }
}