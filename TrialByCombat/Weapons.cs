using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;




namespace TrialByCombat
{
    class Weapons
    {
        public void GetWeapon()
        {

            string weaponList = @"{
                'weapons': [{
                    'name': 'Club',
                    'cost': '1 sp',
                    'damage': '1d4',
                    'damageType': 'bludgeoning',
                    'weight': '2 lb',
                    'properties': 'light'
                    },
                    {
                    'name': 'Dagger',
                    'cost': '2 gp',
                    'damage': '1d4',
                    'damageType': 'piercing',
                    'weight': '1 lb',
                    'properties': 'light'
                    },
                    {
                    'name': 'Greatclub',
                    'cost': '2 sp',
                    'damage': '1d8',
                    'damageType': 'bludgeoning',
                    'weight': '10 lb',
                    'properties': 'light'
                    },
                    {
                    'name': 'Handaxe',
                    'cost': '5 gp',
                    'damage': '1d6',
                    'damageType': 'slashing',
                    'weight': '2 lb',
                    'properties': 'light'
                    },
                    {
                    'name': 'Javelin',
                    'cost': '5 sp',
                    'damage': '1d6',
                    'damageType': 'piercing',
                    'weight': '2 lb',
                    'properties': 'light'
                    },
                    {
                    'name': 'Light Hammer',
                    'cost': '1 sp',
                    'damage': '1d4',
                    'damageType': 'bludgeoning',
                    'weight': '2 lb',
                    'properties': 'light'
                    },
                    {
                    'name': 'Mace',
                    'cost': '1 sp',
                    'damage': '1d6',
                    'damageType': 'bludgeoning',
                    'weight': '2 lb',
                    'properties': 'light'
                    },
                    {
                    'name': 'Quarterstaff',
                    'cost': '1 sp',
                    'damage': '1d6',
                    'damageType': 'bludgeoning',
                    'weight': '2 lb',
                    'properties': 'light'
                    },
                    {
                    'name': 'Sickle',
                    'cost': '1 sp',
                    'damage': '1d4',
                    'damageType': 'slashing',
                    'weight': '2 lb',
                    'properties': 'light'
                    },
                    {
                    'name': 'Spear',
                    'cost': '1 sp',
                    'damage': '1d6',
                    'damageType': 'piercing',
                    'weight': '2 lb',
                    'properties': 'light'
                    }
                ]
            }";

            JObject weapons = JObject.Parse(weaponList);
            // orginal code for random weapon each fight
            
            //var rand = new Random();
            //int xx = rand.Next(10); // provides 10 numbers 0, 1, 2, 3, 4, 5, 6, 7, 8, 9

            //string xname = (string)weapons["weapons"][xx]["name"];
            //string xdamage = (string)weapons["weapons"][xx]["damage"];
            


            
            int i = 0;
            do
            {
                Console.WriteLine(i + ") " + ((string)weapons["weapons"][i]["name"]) + " \t" + ((string)weapons["weapons"][i]["damage"]));
                i++;
            }while (i <= 9) ;

            Console.WriteLine();
            Console.WriteLine("Which weapon do you choose?");
            string cInput = Console.ReadLine();

            string xname = (string)weapons["weapons"][Int32.Parse(cInput)]["name"];
            string xdamage = (string)weapons["weapons"][Int32.Parse(cInput)]["damage"];

            Console.WriteLine();
            Console.WriteLine("You have choosen the " + xname + " doing " + xdamage + " damage.");
            Console.WriteLine();

            Variables.SetWeaponName(xname);
            Variables.SetWeaponDmg(xdamage);
        }
    }
}


