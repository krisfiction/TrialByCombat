using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class BattleAxe : Weapon
    {
        public BattleAxe(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Battle Axe";
            Description = "a battle axe";
            Slot = "Main Hand";
            Gold = 1500;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 10;
            DamageHigh = 25;
        }
    }
}