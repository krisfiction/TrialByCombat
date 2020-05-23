using System;
using System.Collections.Generic;

namespace TrialByCombat
{
    public class Inventory
    {
        //Items
        private string _type;
        private string _name;
        private string _description;
        private string _slot;
        private int _gold;

        //Equipment
        private string _prefixName;
        private string _prefixStat;
        private int _prefixValue;
        private string _suffixName;
        private string _suffixStat;
        private int _suffixValue;

        //Armor
        private int _armorClass;

        //Weapons
        private int _damageLow;
        private int _damageHigh;

        public static List<Inventory> Inventories { get; set; }

        public Inventory()
        { }


        // Armor
        public Inventory(string Type, string Name, string Description, string Slot, int Gold, string PrefixName, string PrefixStat, int PrefixValue, string SuffixName, string SuffixStat, int SuffixValue, int ArmorClass)
        {
            _type = Type;
            _name = Name;
            _description = Description;
            _slot = Slot;
            _gold = Gold;

            _prefixName = PrefixName;
            _prefixStat = PrefixStat;
            _prefixValue = PrefixValue;
            _suffixName = SuffixName;
            _suffixStat = SuffixStat;
            _suffixValue = SuffixValue;

            _armorClass = ArmorClass;
        }

        //Weapons
        public Inventory(string Type, string Name, string Description, string Slot, int Gold, string PrefixName, string PrefixStat, int PrefixValue, string SuffixName, string SuffixStat, int SuffixValue, int DamageLow, int DamageHigh)
        {
            _type = Type;
            _name = Name;
            _description = Description;
            _slot = Slot;
            _gold = Gold;

            _prefixName = PrefixName;
            _prefixStat = PrefixStat;
            _prefixValue = PrefixValue;
            _suffixName = SuffixName;
            _suffixStat = SuffixStat;
            _suffixValue = SuffixValue;

            _damageLow = DamageLow;
            _damageHigh = DamageHigh;
        }

        //TODO everything below needs upgraded to new system


        public void Initialize()
        {
            Inventories = new List<Inventory>();
        }





        public static void Display(Player player)
        {
            Console.Clear();

            if (Inventories.Count == 0)
            {
                Console.WriteLine("Inventory Empty.");
            }
            else
            {
                Console.WriteLine("Inventory:");
                Console.WriteLine();

                int i = 0;
                do
                {


                    //todo fix display format to remove " " when there is no prefix

                    if ((Inventories[i]._type == "Weapon") && (Inventories[i]._prefixStat == "Damage Done"))
                    {
                        Console.WriteLine(i + ") " + Inventories[i]._prefixName + " " + Inventories[i]._name + " " + Inventories[i]._suffixName + " +" + Inventories[i]._prefixValue + " Type: " + Inventories[i]._type + " Damage: " +  (Inventories[i]._damageLow + Inventories[i]._prefixValue) + "-" + (Inventories[i]._damageHigh + Inventories[i]._prefixValue));
                    }
                    else if (Inventories[i]._type == "Weapon")
                    {
                        Console.WriteLine(i + ") " + Inventories[i]._prefixName + " " + Inventories[i]._name + " " + Inventories[i]._suffixName + " Type: " + Inventories[i]._type + " Damage: " + Inventories[i]._damageLow + "-" + Inventories[i]._damageHigh);
                    }


                    if (Inventories[i]._type == "Armor")
                    {
                        Console.WriteLine(i + ") " + Inventories[i]._prefixName + " " + Inventories[i]._name + " " + Inventories[i]._suffixName);

                        //Console.WriteLine($"{i,2}) {Inventories[i]._slot,-10} {Inventories[i]._prefixName + " " + Inventories[i]._name + " of the " + Inventories[i]._suffixName,-40}{"Armor Class:",-11} {Inventories[i]._armorClass,2}     {"Gold:",-5} {Inventories[i]._gold,5}");


                        //todo better formating for display
                        //todo two lines
                        //todo 1) CHEST     Godly Rags of The Whale
                        //todo         Armor: 6     Health: 20          Gold: 25
                        //todo or
                        //todo 1) CHEST     Godly Rags of the Whale     AC: 6     HP: 20     G: 25
                        // Console.WriteLine($"{i,2}) {Inventories[i]._slot,-10}, {Inventories[i]._prefixName + " " + Inventories[i]._name + " " + Inventories[i]._suffixName,-40} {"Armor Class:",-11} {Inventories[i]._armorClass,2}");
                        //Console.WriteLine($"{Inventories[i]._prefixStat, 10}: {Inventories[i]._prefixValue, 4}, {Inventories[i]._suffixStat,10}: {Inventories[i]._suffixValue,4}  {"Gold:",-5} {Inventories[i]._gold,5}");


                        //if (Inventories[i]._prefixStat == "Armor Class") //add prefix armor to base armor
                        //{
                        //    //int ac = (Inventories[i]._armorClass + Inventories[i]._prefixValue);
                        //    //Console.WriteLine($"{i,2}) {Inventories[i]._slot,-10}{Inventories[i]._prefixName + " " + Inventories[i]._name + " " + Inventories[i]._suffixName,-40} {"Armor Class:",-11} {ac,2}");
                        //    //Console.WriteLine($"{Inventories[i]._suffixStat,10}: {Inventories[i]._suffixValue,4}  {"Gold:",-5} {Inventories[i]._gold,5}");

                        //}
                        //else
                        //{
                        //    Console.WriteLine(i + ")**" + Inventories[i]._prefixName + " " + Inventories[i]._name + " " + Inventories[i]._suffixName);
                        //    //todo need formating
                        // //Console.WriteLine($"{i,2}) {Inventories[i]._slot,-10}, {Inventories[i]._prefixName + " " + Inventories[i]._name + " " + Inventories[i]._suffixName,-40} {"Armor Class:",-11} {Inventories[i]._armorClass,2}");

                        //}

                    }
                    

                    i++;
                } while (i < Inventories.Count);



                Menu(player);

                
            }
        }


        public void Remove(int iTemp)
        {
            Inventories.RemoveAt(iTemp); // removes item from the list
        }




        //! inventory menu - show only Armor, show only weapons ??
        //! move eqiup to seperate method
        public static void Menu(Player player)
        {
            Console.WriteLine();
            Console.WriteLine("equip what weapon? (gear not yet implemented)");
            var sInput = Console.ReadLine();

            if (Int32.TryParse(sInput, out int _number))
            {
                if (_number >= (Inventories.Count))
                {
                    Console.WriteLine("Invalid Number");
                }
                else //todo check what type of item it is and equip to the right slot - everything is currently equipped as a weapon
                {
                   if (Inventories[_number]._prefixStat == "Damage Done")
                    {
                        player.WeaponName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName + " +" + Inventories[_number]._prefixValue;
                        player.WeaponDamageLow = Inventories[_number]._damageLow + Inventories[_number]._prefixValue;
                        player.WeaponDamageHigh = Inventories[_number]._damageHigh + Inventories[_number]._prefixValue;
                    }
                    else
                    {
                        player.WeaponName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName;
                        player.WeaponDamageLow = Inventories[_number]._damageLow;
                        player.WeaponDamageHigh = Inventories[_number]._damageHigh;
                    }

                    Inventories.RemoveAt(_number);
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }


        // temp maybe ??
        public static void EquipStarterWeapon(Player player)
        {
            if (Inventories[0]._prefixStat == "Damage Done")
            {
                player.WeaponName = Inventories[0]._prefixName + " " + Inventories[0]._name + " " + Inventories[0]._suffixName + " +" + Inventories[0]._prefixValue;
                player.WeaponDamageLow = Inventories[0]._damageLow + Inventories[0]._prefixValue;
                player.WeaponDamageHigh = Inventories[0]._damageHigh + Inventories[0]._prefixValue;
            }
            else
            {
                player.WeaponName = Inventories[0]._prefixName + " " + Inventories[0]._name + " " + Inventories[0]._suffixName;
                player.WeaponDamageLow = Inventories[0]._damageLow;
                player.WeaponDamageHigh = Inventories[0]._damageHigh;
            }
            Inventories.RemoveAt(0);
        }






        /*
        * drop on ground
        * equip 
        * return to game
        */

    }
}
