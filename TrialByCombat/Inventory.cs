using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TrialByCombat
{
    public class Inventory
    {
        //private string _name;
        //private string _type;
        //private string _slot;
        //private int _gold;
        private string _damage; //delete
        private string _info; //delete

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

        public static List<Inventory> Inventories { get; set; }

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

        //TODO everything below needs upgraded to new system



        public Inventory(string Name, string Type, string Slot, int Gold, string Damage, string Info)
        {
            _name = Name;
            _type = Type;
            _slot = Slot;
            _gold = Gold;
            _damage = Damage;
            _info = Info;
        }
        public Inventory(string Name, string Type, string Slot, int Gold, string Info)
        {
            _name = Name;
            _type = Type;
            _slot = Slot;
            _gold = Gold;
            _info = Info;
        }

        public Inventory()
        {
        }

        //public override string ToString()
        //{
        //    if (Type == "Weapon")
        //    {
        //        return "Slot: " + Slot + "\tSlotNumber: " + SlotNumber + "\tName: " + Name + "\tType: " + Type + "\tGold: " + Gold + "\tdamage: " + Damage;
        //        //return "Slot: " + Slot + " SlotNumber: " + SlotNumber + " Name: " + Name + " Type: " + Type + " Gold: " + Gold + " damage: " + Damage;
        //    }
        //    else
        //    {
        //        return "Slot: " + Slot + "\tSlotNumber: " + SlotNumber + "\tName: " + Name + "\tType: " + Type + "\tGold: " + Gold;
        //        //return "Slot: " + Slot + " SlotNumber: " + SlotNumber + " Name: " + Name + " Type: " + Type + " Gold: " + Gold;
        //    }
        //}

        public void Initialize()
        {
            Inventories = new List<Inventory>();

            //Inventories.Add(new Inventory("Padded Helmet", "Gear", "Head", 5, "this is a helmet"));
            //Inventories.Add(new Inventory("Steel Sword", "Weapon", "Main Hand", 10, "2d10", "this is a sword"));
        }





        public static void Display()
        {
            Console.Clear();

            
            int i = 0;
            do
            {
                if (Inventories[i]._type == "Weapon")
                {
                    Console.WriteLine(i + ") " + Inventories[i]._name + " Type: " + Inventories[i]._type + " Damage: " + Inventories[i]._damage);
                }else
                if (Inventories[i]._type == "Armor")
                {
                    Console.WriteLine($"{i,2}) {Inventories[i]._slot,-10} {Inventories[i]._prefixName + " " + Inventories[i]._name + " of the " + Inventories[i]._suffixName,-40}{"Armor Class:",-11} {Inventories[i]._armorClass,2}     {"Gold:",-5} {Inventories[i]._gold,5}");
                }
                else
                {
                    //Console.WriteLine(i + ") "
                    //    + Inventories[i]._slot + "\t"
                    //    + Inventories[i]._prefixName + " "
                    //    + Inventories[i]._name + " of the "
                    //    + Inventories[i]._suffixName + "\tArmor Class: "
                    //    + Inventories[i]._armorClass + "\tGold: "
                    //    + Inventories[i]._gold);

                    Console.WriteLine("OOPS");
                   // Console.WriteLine($"{i,2}) {Inventories[i]._slot,-10} {Inventories[i]._prefixName + " " + Inventories[i]._name + " of the " + Inventories[i]._suffixName,-40}{"Armor Class:", -11} {Inventories[i]._armorClass,2}     {"Gold:", -5} {Inventories[i]._gold,5}");
                    //  slot 9 use 14
                    //   Vulnerable Studded Leather of the Vulture  41 chatacyers -- use 46 
                    //  armor class: XX  15 --> 20
                    //  gold: XXXXX   11 --> 16

                }
                
                i++;
            } while (i < Inventories.Count);
            







            //TODO move to seperate method -- Menu() ??
            Console.WriteLine();
            Console.WriteLine("equip what item?");
            var sInput = Console.ReadLine();

            if (Int32.TryParse(sInput, out int _number))
            {
                if (_number >= (Inventories.Count))
                {
                    Console.WriteLine("Invalid Number"); //TODO needs fixed
                }
                else
                {
                    Inventories.RemoveAt(_number);
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }







        }


        public void Remove(int iTemp)
        {
            //inventories.RemoveAt(int.Parse(temp)); // removes item from the list
            Inventories.RemoveAt(iTemp); // removes item from the list
        }


        //TODO inventory menu
        /*
        * drop on ground
        * equip 
        */
            
    }
}
