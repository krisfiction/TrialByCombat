﻿using System;

namespace TrialByCombat
{
    class GearList
    {
        public void GetGear(string theslot)
        {
            string theSlot = theslot;


            string[] geartype = new string[5];
            geartype[0] = "padding";
            geartype[1] = "leather";
            geartype[2] = "studded leather";
            geartype[3] = "chain mail";
            geartype[4] = "plate";



            var rand = new Random();
            int xx = rand.Next(5);
            int yy = rand.Next(5);

            string xname = geartype[xx];

            //string xcost = "1";
            int xcost = 1;
            //string xweight = "2";
            int xweight = 2;
            int xarmorBonus = yy + 1;




            // move to EquipGear() ??
            switch (theSlot)
            {
                case "head":
                    if (xarmorBonus > Player.HeadArmorBonus) // if armor bonus is bigger then it is a upgrade
                    {
                        Player.HeadName = xname;
                        Player.HeadArmorBonus = xarmorBonus;
                        Player.HeadWeight = xweight;
                        Player.HeadCost = xcost;

                        //Console.WriteLine("you recieve a " + Player.HeadName + " " + theSlot + " +" + Player.HeadArmorBonus + " costs " + Player.HeadArmorBonus + " gold and weighs " + Player.HeadWeight + " pounds");
                        Console.WriteLine("you recieve a " + Player.HeadName + " helmet +" + Player.HeadArmorBonus);

                    }




                    /*
                    Gear back = new Gear
                    {
                        Cost = Convert.ToInt32(xcost),
                        Name = xname,
                        Weight = Convert.ToInt32(xweight),
                        ArmorBonus = xarmorBonus
                    };
                    Console.WriteLine("the " + back.Name + " " + theSlot + " +" + back.ArmorBonus + " costs " + back.Cost + " gold and weighs " + back.Weight + " pounds");
                    */
                    break;

                case "chest":
                    if (xarmorBonus > Player.ChestArmorBonus)
                    {
                        Player.ChestName = xname;
                        Player.ChestArmorBonus = xarmorBonus;
                        Player.ChestWeight = xweight;
                        Player.ChestCost = xcost;

                        Console.WriteLine("you recieve a " + Player.ChestName + " chest +" + Player.ChestArmorBonus + " costs " + Player.ChestArmorBonus);

                      
                    }
                    /*
                    Gear chest = new Gear
                    {
                        Cost = Convert.ToInt32(xcost),
                        Name = xname,
                        Weight = Convert.ToInt32(xweight),
                        ArmorBonus = xarmorBonus
                    };
                    Console.WriteLine("SLOT: " + theSlot + ", the " + chest.Name + " +" + chest.ArmorBonus + " costs " + chest.Cost + " gold and weighs " + chest.Weight + " pounds");
                    */
                    break;
            }

            //Console.WriteLine("the " + back.Name + " +" + back.ArmorBonus + " costs " + back.Cost + " gold and weighs " + back.Weight + " pounds");

            //Console.WriteLine(theSlot);
        }
    }
}
