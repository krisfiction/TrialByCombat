using System;

namespace TrialByCombat
{
    static class Combat
    {
        private static readonly Random random = new Random();


        public static void Start(Player player, Monster monster) // remove ??
        {
            Console.Clear();
            Console.WriteLine("Combat started");
            Console.WriteLine();

            DamageDone(player, monster);
        }


        

        public static void DamageDone(Player player, Monster monster)
        {
            player.WeaponDamage = random.Next(player.WeaponDamageLow, player.WeaponDamageHigh);

            if (player.WeaponDamage < 0) //for useless, junk, and weak prefix on weeapons
            {
                Console.WriteLine("you do no damage, your weapon is weak!");
                Console.WriteLine();
                MonsterAttack(player, monster);
            }
            else
            {
                Console.WriteLine("Using your " + player.WeaponName + ", you do " + player.WeaponDamage + " damage!");
                Console.WriteLine();

                monster.Health -= player.WeaponDamage;

                MonsterAttack(player, monster);
            }



            //game over code - probably needs moved or a seperate function

            if (player.Health < 1)
            {
                Console.Clear();
                Console.WriteLine("you die");
                Console.WriteLine("you die");
                Console.WriteLine("you die");
                Console.WriteLine("you die");
                Console.WriteLine("you die");

                //add how many monsters you kill and how much gold you recieved

                Console.WriteLine();
                Console.WriteLine("\n" + "press any key to continue.");
                Console.ReadKey();

                player.Health = 100;
                Program.StartGame(player, monster);

            }
        }

        public static void MonsterAttack(Player player, Monster monster)
        {
            //x add armor into damage calculation
            // damageMultiplier = damage / (damage + armor)
            // finalDamage = damage * damageMultiplier

            monster.WeaponDamage = random.Next(monster.WeaponDamageLow, monster.WeaponDamageHigh);

            if (monster.Health > 0)
            {
                if (player.Shield > monster.WeaponDamage)
                {
                    player.Shield -= monster.WeaponDamage;
                    Console.WriteLine("The " + monster.Name + " strikes back doing " + monster.WeaponDamage + " damage");
                    Console.WriteLine("But your magic shield absorbed the damage!");
                }
                else
                {
                    //Console.WriteLine("weapon damage: " + monster.WeaponDamage);
                    int premultiplier = monster.WeaponDamage + player.AC;
                    //Console.WriteLine("pre: " + premultiplier);
                    double multiplier = (double)monster.WeaponDamage / (double)premultiplier;
                    //Console.WriteLine("total: " + multiplier);
                    double total = monster.WeaponDamage * multiplier;
                    //Console.WriteLine("total: " + (int)Math.Round(total, 0));



                    Console.WriteLine("The " + monster.Name + " strikes back doing " + monster.WeaponDamage + " damage");
                    Console.WriteLine("Your armor of " + player.AC + " absorbs " + (int)Math.Round(monster.WeaponDamage - total, 0) + " points of damage and you take " + (int)Math.Round(total, 0) + " damage");


                    player.Health -= (int)Math.Round(total, 0) - player.Shield;
                    player.Shield = 0;
                }


            }
        }
    }
}
