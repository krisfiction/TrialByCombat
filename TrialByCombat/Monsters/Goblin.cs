using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Monsters
{
    class Goblin : Monster
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 20;
            HealthMax = 20;
            Gold = 20;
            DamageRoll = "2d10";
            Damage = 20;
        }
    }
}
