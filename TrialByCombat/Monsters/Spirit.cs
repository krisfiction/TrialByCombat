using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Monsters
{
    internal class Spirit : Monster
    {
        public Spirit()
        {
            Name = "Spirit";
            HealthLow = 72;
            HealthHigh = 96;
            Gold = 10;
            WeaponDamageLow = 14;
            WeaponDamageHigh = 26;
        }
    }
}
