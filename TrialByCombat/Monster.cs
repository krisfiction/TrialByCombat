using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace TrialByCombat
{
    public class Monster
    {

        /*
        //Monster.Name
        private static string _name = "rat";

        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        */
        public static string Name { get; set; } = "rat";

        /*
        //Monster.HP
        private static int _hp = 10;

        public static int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        */
        public static int HP { get; set; } = 10;

        public static int HPmax { get; set; } = 10;

        public static int MANA { get; set; } = 10;

        public static int AC { get; set; } = 10;

        public static int Gold { get; set; } = 10;

        public static string DamageRoll { get; set; } = "2d5";
        public static int Damage { get; set; } = 5;

        public void GetMonster()
        {

            string monsterList = @"{
                'monsters': [{
                    'name': 'Dire Rat',
                    'health': '1d8+1',
                    'damageRoll': '1d4',
                    'gold': '1d10'
                    },
                    {
                    'name': 'Skeleton',
                    'health': '1d8',
                    'damageRoll': '1d4+1',
                    'gold': '1d20'
                    },
                    {
                    'name': 'Troll',
                    'health': '6d8+36',
                    'damageRoll': '1d8+5',
                    'gold': '1d30'
                    },
                    {
                    'name': 'Orge',
                    'health': '4d8+12',
                    'damageRoll': '2d8+7',
                    'gold': '1d40'
                    },
                    {
                    'name': 'Goblin',
                    'health': '1d10+1',
                    'damageRoll': '1d4',
                    'gold': '1d50'
                    },
                    {
                    'name': 'Orc Fighter',
                    'health': '10d10',
                    'damageRoll': '2d4+7',
                    'gold': '1d60'
                    },
                    {
                    'name': 'Merfolk',
                    'health': '1d10+2',
                    'damageRoll': '1d8+1',
                    'gold': '1d70'
                    },
                    {
                    'name': 'Cave Scorpion',
                    'health': '3d8+3',
                    'damageRoll': '1d4',
                    'gold': '1d80'
                    },
                    {
                    'name': 'Ghoul',
                    'health': '2d8+4',
                    'damageRoll': '1d6+1',
                    'gold': '1d90'
                    },
                    {
                    'name': 'Giant Black Widow Spider',
                    'health': '5d8+15',
                    'damageRoll': '1d8+6',
                    'gold': '1d100'
                    }
                ]
            }";

            JObject monsters = JObject.Parse(monsterList);

            var rand = new Random();
            int yy = rand.Next(10); // provides 10 numbers 0, 1, 2, 3, 4, 5, 6, 7, 8, 9

            string yname = (string)monsters["monsters"][yy]["name"];
            string yhealth = (string)monsters["monsters"][yy]["health"];
            //string ydamageRoll = (string)monsters["monsters"][yy]["damageRoll"];
            string ygold = (string)monsters["monsters"][yy]["gold"];

            //Console.WriteLine();
            //Console.WriteLine("TEST INFO ONE name: " + yname + ", health: " + yhealth + ", damage: " + ydamageRoll + ", gold: " + ygold);
            //Console.WriteLine();

            Monster.Name = yname;

            DiceRoller diceRoller = new DiceRoller();
            diceRoller.Start(yhealth);
            HP = Variables.Total;
            HPmax = HP;

            //diceRoller.Start(ydamageRoll);
            //Damage = Variables.Total;
            // Damage = Int32.Parse(ydamageRoll);
            DamageRoll = (string)monsters["monsters"][yy]["damageRoll"];  //ydamageRoll;


            diceRoller.Start(ygold);
            Gold = Variables.Total;

            //Console.WriteLine();
            //Console.WriteLine("TEST INFO TWO name: " + Name + ", health: " + HP + ", damage: " + DamageRoll + ", gold: " + Gold);
            //Console.WriteLine();

        }
    }
}