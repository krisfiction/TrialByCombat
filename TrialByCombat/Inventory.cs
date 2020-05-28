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
                bool _WeaponTitle = false;
                bool _ArmorTitle = false;

                int _lineNumber = 0;
                foreach (var Inventory in Inventories)
                {
                    if (_WeaponTitle == false)
                    {
                        Console.WriteLine("Weapons:");
                        _WeaponTitle = true;
                    }
                    else if (Inventory._type == "Weapon")
                    {
                        if (Inventory._type == "Weapon" && Inventory._prefixStat == "Damage Done")
                        {
                            Console.WriteLine($"{_lineNumber,2}) {Inventory._type,-10}{Inventory._prefixName + " " + Inventory._name + " " + Inventory._suffixName,-40}{"+",-2}{Inventory._prefixValue,-3}{"Damage:",8} {Inventory._damageLow + Inventory._prefixValue}-{Inventory._damageHigh + Inventory._prefixValue}");
                        }
                        else if (Inventory._type == "Weapon")
                        {
                            Console.WriteLine($"{_lineNumber,2}) {Inventory._type,-10}{Inventory._name + " " + Inventory._suffixName,-40}{"",5}{"Damage:",8} {Inventory._damageLow}-{Inventory._damageHigh}");
                        }
                    }
                    _lineNumber++;
                }

                _lineNumber = 0;
                foreach (var Inventory in Inventories)
                {
                    if (_ArmorTitle == false)
                    {
                        Console.WriteLine("Armor:");
                        _ArmorTitle = true;
                    }
                    else if (Inventory._type == "Armor")
                    {
                        if (Inventory._type == "Armor" && Inventory._prefixStat == "Armor Class")
                        {
                            Console.WriteLine($"{_lineNumber,2}) {Inventory._slot,-10}{Inventory._prefixName + " " + Inventory._name + " " + Inventory._suffixName,-40}{"Armor: ",14}{Inventory._armorClass}");
                        }
                        else if (Inventory._type == "Armor")
                        {
                            Console.WriteLine($"{_lineNumber,2}) {Inventory._slot,-10}{Inventory._name + " " + Inventory._suffixName,-40}{"Armor: ",14}{Inventory._armorClass}");
                        }
                    }

                    _lineNumber++;
                
                }

                //todo better formating for display
                //todo two lines
                //todo 1) CHEST     Godly Rags of The Whale
                //todo         Armor: 6     Health: 20          Gold: 25
                //todo or
                //todo 1) CHEST     Godly Rags of the Whale     AC: 6     HP: 20     G: 25
                        


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
            Console.WriteLine("What would you like to wear / wield?");
            var sInput = Console.ReadLine();

            if (Int32.TryParse(sInput, out int _number))
            {
                if (_number >= (Inventories.Count))
                {
                    Console.WriteLine("Invalid Number");
                }
                else
                {
                    if (Inventories[_number]._type == "Weapon")
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
                    }
                    else if (Inventories[_number]._type == "Armor")
                    {
                        switch (Inventories[_number]._slot)
                        {
                            case "Head":
                                Console.WriteLine("you choose Head");
                                player.HeadName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName;
                                player.HeadArmorBonus = Inventories[_number]._armorClass;
                                break;

                            case "Shoulders":
                                player.ShouldersName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName;
                                player.ShouldersArmorBonus = Inventories[_number]._armorClass;
                                break;

                            case "Arms":
                                player.ArmsName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName;
                                player.ArmsArmorBonus = Inventories[_number]._armorClass;
                                break;

                            case "Hands":
                                player.HandsName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName;
                                player.HandsArmorBonus = Inventories[_number]._armorClass;
                                break;

                            case "Chest":
                                player.ChestName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName;
                                player.ChestArmorBonus = Inventories[_number]._armorClass;
                                break;

                            case "Waist":
                                player.WaistName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName;
                                player.WaistArmorBonus = Inventories[_number]._armorClass;
                                break;

                            case "Legs":
                                player.LegsName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName;
                                player.LegsArmorBonus = Inventories[_number]._armorClass;
                                break;

                            case "Feet":
                                player.FeetName = Inventories[_number]._prefixName + " " + Inventories[_number]._name + " " + Inventories[_number]._suffixName;
                                player.FeetArmorBonus = Inventories[_number]._armorClass;
                                break;
                        }

                    }

                    //todo display what item you chose to equip / wield
                    //todo check if item is already in chosen slot
                    //todo if item alreadys exists, remove item back to inventory

                    //update player stats - needs moved
                    player.AC = player.ACbase + player.HandsArmorBonus + player.ShouldersArmorBonus + player.ArmsArmorBonus + player.HandsArmorBonus + player.ChestArmorBonus + player.WaistArmorBonus + player.LegsArmorBonus + player.FeetArmorBonus;

                    //remove item from inventory
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
            System.Threading.Thread.Sleep(1000); //test to see if calling before weapon is created and causing a crash 


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
