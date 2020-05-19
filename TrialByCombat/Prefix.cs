using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace TrialByCombat
{
    internal class Prefix
    {
        private static readonly Random random = new Random();

        private string _name;
        private string _statName;
        private int _valueLow;
        private int _valueHigh;
       // private int _value;
        private string _occurrence;

        private static string name;
        private static string statName;
        private static int value;

        public static List<Prefix> Prefixes { get; set; }

        public Prefix(string Name, string StatName, int ValueLow, int ValueHigh, string Occurrence)
        {
            _name = Name;
            _statName = StatName;
            _valueLow = ValueLow;
            _valueHigh = ValueHigh;
            _occurrence = Occurrence;
        }

        public Prefix()
        {

        }

        public static void Initialize()
        {
            Prefixes = new List<Prefix>
            {
                //"name", "stat name", Value low, Value high, "occurence"
               
                //Mana - 8 items
                new Prefix("Hyena’s", "Mana", -25, -11, "TJ"),
                new Prefix("Frog’s", "Mana", -10, -1, "TJ"),
                new Prefix("Spider’s", "Mana", 10, 15, "TJ"),
                new Prefix("Raven’s", "Mana", 15, 20, "TJ"),
                new Prefix("Snake’s", "Mana", 21, 30, "TJ"),
                new Prefix("Serpent’s", "Mana", 30, 40, "TJ"),
                new Prefix("Drake’s", "Mana", 41, 50, "TJ"),
                new Prefix("Dragon’s", "Mana", 51, 60, "TJ"),
                

             
                //Resist All


                //Armor Class - 12 items
                new Prefix("Vulnerable", "Armor Class", -100, -50, "AS"),
                new Prefix("Rusted", "Armor Class", -50, -25, "AS"),
                new Prefix("Fine", "Armor Class", 20, 30, "AS"),
                new Prefix("Strong", "Armor Class", 31, 40, "AS"),
                new Prefix("Grand", "Armor Class", 41, 55, "AS"),
                new Prefix("Valiant", "Armor Class", 56, 70, "AS"),
                new Prefix("Glorious", "Armor Class", 71, 90, "AS"),
                new Prefix("Blessed", "Armor Class", 91, 110, "AS"),
                new Prefix("Saintly", "Armor Class", 111, 130, "AS"),
                new Prefix("Awesome", "Armor Class", 131, 150, "AS"),
                new Prefix("Holy", "Armor Class", 151, 170, "AS"),
                new Prefix("Godly", "Armor Class", 171, 200, "AS"),


                //Hit

                
                //Damage Done - 12 items
                new Prefix("Useless", "Damage Done", -100, -70, "WB"),
                new Prefix("Bent", "Damage Done", -75, -50, "WB"),
                new Prefix("Weak", "Damage Done", -45, -25, "WB"),
                new Prefix("Jagged", "Damage Done", 20, 35, "WB"),
                new Prefix("Deadly", "Damage Done", 36, 50, "WB"),
                new Prefix("Heavy", "Damage Done", 51, 65, "WB"),
                new Prefix("Vicious", "Damage Done", 66, 80, "WB"),
                new Prefix("Brutal", "Damage Done", 81, 95, "WB"),
                new Prefix("Massive", "Damage Done", 96, 110, "WB"),
                new Prefix("Savage", "Damage Done", 111, 125, "WB"),
                new Prefix("Ruthless", "Damage Done", 126, 150, "WB"),
                new Prefix("Merciless", "Damage Done", 151, 175, "WB")
                

                //Hit, Damage Done  (2 stats, WHAT DO!)



            };
        }


        public static (string pname, string pstat, int pvalue) Generate(string Slot)
        {
            //get random prefix Stat
            //get Value of that Stat
            //if Value fits Slot
            //assign prefix

            Initialize(); //moveed to game start up
            
            int i = random.Next(0,32); // random item from Prefixes list 
            if (Slot == "Armor" && Prefixes[i]._occurrence.Contains("A"))
            {
                name = Prefixes[i]._name;
                statName = Prefixes[i]._statName;
                value = (random.Next(Prefixes[i]._valueLow, Prefixes[i]._valueHigh));
            }
            if (Slot == "Weapon" && Prefixes[i]._occurrence.Contains("W"))
            {
                name = Prefixes[i]._name;
                statName = Prefixes[i]._statName;
                value = (random.Next(Prefixes[i]._valueLow, Prefixes[i]._valueHigh));
            }
            else
            { //fail safe - make game break - not sure why ???
                //name = "FAIL";
                //statName = "statFAIL";
                //value = 88888;
            }
            return (name, statName, value);
        }
    }
}
