using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Monsters
{
    internal class Rat : Monster
    {
        public Rat()
        {
            Name = "Rat";
            HealthLow = 10;
            HealthHigh = 15;
            Gold = 10;
            WeaponDamageLow = 2;
            WeaponDamageHigh = 10;
        }
    }
}
