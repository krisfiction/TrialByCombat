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

            //Console.WriteLine(Player.Name + ", HP " + Player.HP + " - " + Monster.Name + ", HP " + Monster.HP);

            DamageDone();

            //Console.WriteLine(Player.Name + ", HP " + Player.HP + " - " + Monster.Name + ", HP " + Monster.HP);

            //StatBar statbar = new StatBar();
            //statbar.DisplayStatBar();
            StatBar.DisplayStatBar();
        }


        public void DamageDone()
        {
            DiceRoller diceRoller = new DiceRoller();
            diceRoller.Start(Variables.weaponDmg);

            Console.WriteLine("Using your " + Variables.weaponName + ", rolling a " + Variables.weaponDmg + ", you do " + Variables.Total + " damage");
            Console.WriteLine();

            //Monster.HP = Monster.HP - Variables.Total;
            Monster.HP -= Variables.Total;


            diceRoller.Start(Monster.DamageRoll); //change to monster.weapon or monster.attack ??
            Monster.Damage = Variables.Total;

            Console.WriteLine("The " + Monster.Name + " strikes back rolling a " + Monster.DamageRoll + " doing " + Monster.Damage + " damage");
            Console.WriteLine();
            Player.HP -= Monster.Damage;

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
    }
}
