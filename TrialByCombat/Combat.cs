using System;

namespace TrialByCombat
{
    class Combat
    {
        private static readonly Random random = new Random();
        public void Start(Player player, Monster monster)
        {
            Console.Clear(); //may need moved ??
            Console.WriteLine("Combat started");
            Console.WriteLine();

            DamageDone(player, monster);

        }


        //todo weapons with negative damage will currently heal monsters 

        public void DamageDone(Player player, Monster monster)
        {
            DiceRoller diceRoller = new DiceRoller();
            //diceRoller.Start(Variables.weaponDmg);

            Variables.weaponDamage = random.Next(Variables.weaponDamageLow, Variables.weaponDamageHigh);


            Console.WriteLine("Using your " + Variables.weaponName + ", you do " + Variables.weaponDamage + " damage!");
            Console.WriteLine();

            monster.Health -= Variables.weaponDamage;



            MonsterAttack(player, monster);





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
                DiceRoller diceRoller = new DiceRoller();

                diceRoller.Start(monster.DamageRoll);
                monster.Damage = Variables.Total;

                Console.WriteLine("The " + monster.Name + " strikes back rolling a " + monster.DamageRoll + " doing " + monster.Damage + " damage");

                if (player.Shield > monster.Damage)
                {
                    player.Shield -= monster.Damage;
                }
                else
                if (monster.Damage > (player.ChestArmorBonus + player.HeadArmorBonus))
                {
                    player.Health -= ((monster.Damage -= player.Shield) - (player.ChestArmorBonus + player.HeadArmorBonus));

                    player.Shield = 0;
                }
            }
        }
    }
}
