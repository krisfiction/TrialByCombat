using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Monsters
{
    class Rat : Monster
    {
        public Rat()
        {
            Name = "Rat";
            Health = 10;
            HealthMax = 10;
            Gold = 10;
            DamageRoll = "2d5";
            Damage = 5;
        }
    }
}
