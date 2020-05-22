using System;

namespace TrialByCombat
{
    class Combat
    {
        private static readonly Random random = new Random();


        public void Start(Player player, Monster monster) // remove ??
        {
            Console.Clear();
            Console.WriteLine("Combat started");
            Console.WriteLine();

            DamageDone(player, monster);
        }


        

        public void DamageDone(Player player, Monster monster)
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
                Program.StartGame(player);

            }
        }

        public void MonsterAttack(Player player, Monster monster)
        {
            if (monster.Health > 0)
            {
                monster.WeaponDamage = random.Next(monster.WeaponDamageLow, monster.WeaponDamageHigh);

                Console.WriteLine("The " + monster.Name + " strikes back doing " + monster.WeaponDamage + " damage");

                if (player.Shield > monster.WeaponDamage)
                {
                    player.Shield -= monster.WeaponDamage;
                }
                else
                if (monster.WeaponDamage > (player.ChestArmorBonus + player.HeadArmorBonus))
                {
                    player.Health -= ((monster.WeaponDamage -= player.Shield) - (player.ChestArmorBonus + player.HeadArmorBonus));

                    player.Shield = 0;
                }
            }
        }
    }
}
