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
               
                //Strength

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

           Initialize();

            int i = random.Next(0, 10); // random item from Suffixes list
            if (Slot == "Armor" && Suffixes[i]._occurrence.Contains("A"))
            {
                name = Suffixes[i]._name;
                statName = Suffixes[i]._statName;
                value = (random.Next(Suffixes[i]._valueLow, Suffixes[i]._valueHigh));
            }
            if (Slot == "Weapon" && Suffixes[i]._occurrence.Contains("W"))
            {
                name = Suffixes[i]._name;
                statName = Suffixes[i]._statName;
                value = (random.Next(Suffixes[i]._valueLow, Suffixes[i]._valueHigh));
            }
            else
            //{
            //name = "FAIL";
            //statName = "statFAIL";
            //value = 88888;
            //}
            return (name, statName, value);
            return default;
        }
    }
}
