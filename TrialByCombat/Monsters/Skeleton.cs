using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Monsters
{
    internal class Skeleton : Monster
    {
        public Skeleton()
        {
            Name = "Skeleton";
            HealthLow = 104;
            HealthHigh = 108;
            Gold = 10;
            WeaponDamageLow = 10;
            WeaponDamageHigh = 22;
        }
    }
}
