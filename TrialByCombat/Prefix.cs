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
               

                //Armor Class
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
                new Prefix("Godly", "Armor Class", 171, 200, "AS")
            };
        }


        public static (string pname, string pstat, int pvalue) Generate(string Slot)
        {
            //get random prefix Stat
            //get Value of that Stat
            //if Value fits Slot
            //assign prefix

            Initialize(); //move to game start up ??


            //pick random item from Prefix[X] list
            //assign propertys

       



            int i = random.Next(0,12); // random item from Prefixes list

            //todo random item from prefix list here
            
            //todo do _valueLow, _valueHigh math --> assign to pValue


            if (Slot == "Armor" & (Prefixes[i]._occurrence.Contains("A")))
            {
                name = Prefixes[i]._name;
                statName = "value";
                value = (random.Next(Prefixes[i]._valueLow, Prefixes[i]._valueHigh));
            }
            else
            {
                name = "FAIL";
                statName = "value";
                value = 3;
            }
            return (name, statName, value);
        }
    }
}
