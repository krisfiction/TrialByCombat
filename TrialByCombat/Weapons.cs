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

            var rand = new Random();
            int xx = rand.Next(10); // provides 10 numbers 0, 1, 2, 3, 4, 5, 6, 7, 8, 9

            string xname = (string)weapons["weapons"][xx]["name"];
            string xdamage = (string)weapons["weapons"][xx]["damage"];


            Variables.SetWeaponName(xname);
            Variables.SetWeaponDmg(xdamage);
            //Console.WriteLine("name: " + xname + "damage: " + xdamage);
        }


    }
}


