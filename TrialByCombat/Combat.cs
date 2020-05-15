using System;

namespace TrialByCombat
{
    class Combat
    {
        public void Start()
        {
            Console.Clear(); //may need moved ??
            Console.WriteLine("Combat started");
            Console.WriteLine();

            DamageDone();

        }


        public void DamageDone()
        {
            DiceRoller diceRoller = new DiceRoller();
            diceRoller.Start(Variables.weaponDmg);

            Console.WriteLine("Using your " + Variables.weaponName + ", rolling a " + Variables.weaponDmg + ", you do " + Variables.Total + " damage");
            Console.WriteLine();

            Monster.HP -= Variables.Total;



            MonsterAttack();





            //game over code - probably needs moved or a seperate function

            if (Player.HP < 1)
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

                Player.HP = 100;
                Program.StartGame();

            }
        }

        public void MonsterAttack()
        {
            DiceRoller diceRoller = new DiceRoller();

            diceRoller.Start(Monster.DamageRoll);
            Monster.Damage = Variables.Total;

            Console.WriteLine("The " + Monster.Name + " strikes back rolling a " + Monster.DamageRoll + " doing " + Monster.Damage + " damage");


            if (Player.Shield > Monster.Damage)
            {
                Player.Shield -= Monster.Damage;
            }
            else
            if (Monster.Damage > (Player.ChestArmorBonus + Player.HeadArmorBonus))
            {
                Player.HP -= ((Monster.Damage -= Player.Shield) - (Player.ChestArmorBonus + Player.HeadArmorBonus));

                Player.Shield = 0;
            }
        }



    }
}
