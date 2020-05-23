using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Monsters
{
    internal class Goblin : Monster
    {
        public Goblin()
        {
            Name = "Goblin";
            HealthLow = 20;
            HealthHigh = 30;
            Gold = 20;
            WeaponDamageLow = 10;
            WeaponDamageHigh = 25;
        }
    }
}
