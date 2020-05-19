using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class Scimitar : Weapon
    {
        public Scimitar(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Scimitar";
            Description = "a scimitar";
            Slot = "Main Hand";
            Gold = 200;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 3;
            DamageHigh = 7;
        }
    }
}