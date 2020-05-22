using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    public class Monster : Characters
    {
        //public string Name { get; set; }

        //public int HP { get; set; } = 11;

        //public int HPmax { get; set; } = 11;

       // public int Gold { get; set; } = 10;

        public string DamageRoll { get; set; } = "2d5";
        public int Damage { get; set; } = 5;
    }
}