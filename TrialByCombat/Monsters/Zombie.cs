using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Monsters
{
    class Zombie : Monster
    {
        public Zombie()
        {
            Name = "Zombie";
            HealthLow = 108;
            HealthHigh = 114;
            Gold = 10;
            WeaponDamageLow = 14;
            WeaponDamageHigh = 26;
        }
    }
}
