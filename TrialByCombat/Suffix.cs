using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    internal class Suffix
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

        public static List<Suffix> Suffixes { get; set; }

        public Suffix(string Name, string StatName, int ValueLow, int ValueHigh, string Occurrence)
        {
            _name = Name;
            _statName = StatName;
            _valueLow = ValueLow;
            _valueHigh = ValueHigh;
            _occurrence = Occurrence;
        }

        public Suffix()
        {

        }

        public static void Initialize()
        {
            Suffixes = new List<Suffix>
            {
                //"name", "stat name", Value low, Value high, "occurence"
               
                //Strength - 7 items
                new Suffix("of Frailty", "Strength", -10, -6, "ASWBJ"),
                new Suffix("of Weakness", "Strength", -5, -1, "ASWBJ"),
                new Suffix("of Strength", "Strength", 1, 5, "ASWBJ"),
                new Suffix("of Might", "Strength", 6, 10, "ASWBJ"),
                new Suffix("of Power", "Strength", 11, 15, "ASWBJ"),
                new Suffix("of Giants", "Strength", 16, 20, "AWBJ"),
                new Suffix("of Titans", "Strength", 21, 30, "WJ"),

                //Vitality

                //All Attributes -- multi add

                //Life - 10 items
                new Suffix("of the Vulture", "HP", -25, -11, "ASJ"),
                new Suffix("of the Jackal", "HP", -10, -1, "ASJ"),
                new Suffix("of the Fox", "HP", 10, 15, "ASJ"),
                new Suffix("of the Jaguar", "HP", 16, 20, "ASJ"),
                new Suffix("of the Eagle", "HP", 21, 30, "ASJ"),
                new Suffix("of the Wolf", "HP", 30, 40, "ASJ"),
                new Suffix("of the Tiger", "HP", 41, 50, "ASJ"),
                new Suffix("of the Lion", "HP", 51, 60, "AJ"),
                new Suffix("of the Mammoth", "HP", 61, 80, "A"),
                new Suffix("of the Whale", "HP", 81, 100, "A")

                //Damage Done

                //Damage Reduction

                //Steal Life

                //Steal Mana

                //Light Radius -- future use
            };
        }


        public static (string pname, string pstat, int pvalue) Generate(string Slot)
        {
            //get random Suffix Stat
            //get Value of that Stat
            //if Value fits Slot
            //assign Suffix

            name = "";
            statName = "";
            value = 0;

            int i = random.Next(0, 17); // random item from Suffixes list
            if (Slot == "Armor" && Suffixes[i]._occurrence.Contains("A"))
            {
                name = Suffixes[i]._name;
                statName = Suffixes[i]._statName;
                value = random.Next(Suffixes[i]._valueLow, Suffixes[i]._valueHigh);
            }

            if (Slot == "Weapon" && Suffixes[i]._occurrence.Contains("W"))
            {
                name = Suffixes[i]._name;
                statName = Suffixes[i]._statName;
                value = random.Next(Suffixes[i]._valueLow, Suffixes[i]._valueHigh);
            }

            return (name, statName, value);
        }
    }
}
