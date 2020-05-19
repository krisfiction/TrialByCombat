using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class SpikedClub : Weapon
    {
        public SpikedClub(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Spiked Club";
            Description = "a spiked club";
            Slot = "Main Hand";
            Gold = 225;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 3;
            DamageHigh = 6;
        }
    }
}