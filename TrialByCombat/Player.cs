using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialByCombat
{
    class Player
    {
        /*
        //Player.Name
        private static string _name = "rogue";

        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        */
        public static string Name { get; set; } = "rogue";

        /*
        //Player.HP
        private static int _hp = 10;

        public static int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        */
        public static int HP { get; set; } = 100;

        public static int HPmax { get; set; } = 100;

        public static int MANA { get; set; } = 10;

        public static int AC { get; set; } = 10;

        public static int Gold { get; set; } = 0;


        public static int STR { get; set; } = 10;
        public static int INT { get; set; } = 10;


        public static string BackName { get; set; } = "Cloth"; // not currently used - looking into how to handle inventory and gear
        public static int BackCost { get; set; } = 0;
        public static int BackWeight { get; set; } = 0;
        public static int BackArmorBonus { get; set; } = 0;


        public static string ChestName { get; set; } = "Cloth"; // not currently used - looking into how to handle inventory and gear
        public static int ChestCost { get; set; } = 0;
        public static int ChestWeight { get; set; } = 0;
        public static int ChestArmorBonus { get; set; } = 0;

        public static int Shield { get; set; } = 0;
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
