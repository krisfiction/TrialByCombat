using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialByCombat.Potions;
using TrialByCombat.Scrolls;

namespace TrialByCombat
{
    public class Player : Characters
    {


        //public string Name { get; set; } = "rogue";

        //public int Health { get; set; } = 100;

        //public int Healthmax { get; set; } = 100;

        public int MANA { get; set; } = 10;


        public int ACbase { get; set; } = 10;
        public int AC { get; set; }




        public int STR { get; set; } = 10;
        public int INT { get; set; } = 10;


        public string HeadName { get; set; } // not currently used - looking into how to handle inventory and gear
        public int HeadCost { get; set; }
        public int HeadWeight { get; set; }
        public int HeadArmorBonus { get; set; }

        public string ShouldersName { get; set; }
        public int ShouldersArmorBonus { get; set; }


        public string ArmsName { get; set; }
        public int ArmsArmorBonus { get; set; }

        public string HandsName { get; set; }
        public int HandsArmorBonus { get; set; }


        public string ChestName { get; set; } = "Cloth"; // not currently used - looking into how to handle inventory and gear
        public int ChestCost { get; set; } = 0;
        public int ChestWeight { get; set; } = 0;
        public int ChestArmorBonus { get; set; } = 0;


        public string WaistName { get; set; }
        public int WaistArmorBonus { get; set; }


        public string LegsName { get; set; }
        public int LegsArmorBonus { get; set; }

        public string FeetName { get; set; }
        public int FeetArmorBonus { get; set; }




        public int Shield { get; set; } = 0;
        /* 
         * name
         * race
         * class
         * title
         * hp
         * mana / spell power
         * ac / armor
         * xp
         * gold
         * 
         * hp regain
         * mana regain
         * 
         * str
         * con
         * wis
         * int
         * dex
         * cha
         * 
         * luck
         * 
         * resist all
         * 
         * light radius
         * 
         * dmg
         * hit
         * defense
         */
    }
}
