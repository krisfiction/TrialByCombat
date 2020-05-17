using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    public class Inventory
    {
        private string _name;
        private string _type;
        private string _slot;
        private int _gold;
        private string _damage;
        private string _info;

        public static List<Inventory> Inventories { get; set; }

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

            Inventories.Add(new Inventory("Padded Helmet", "Gear", "Head", 5, "this is a helmet"));
            Inventories.Add(new Inventory("Steel Sword", "Weapon", "Main Hand", 10, "2d10", "this is a sword"));
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
                {
                    Console.WriteLine(i + ") " + Inventories[i]._name + " Type: " + Inventories[i]._type);
                }
                
                i++;
            } while (i < Inventories.Count);
            

            //foreach (var tempx in inventories)
            //{
            //    //Console.WriteLine($"Name: { tempx._name}");
            //    //Console.WriteLine(") Name: " + tempx._name + " Damage: " + tempx._damage);
            //}







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
