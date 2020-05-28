using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Monsters
{
    internal class Troll : Monster
    {
        public Troll()
        {
            Name = "Troll";
            HealthLow = 25;
            HealthHigh = 52;
            Gold = 10;
            WeaponDamageLow = 18;
            WeaponDamageHigh = 22;
        }
    }
}
