using System;
using TrialByCombat.Scrolls;
using TrialByCombat.Potions;

namespace TrialByCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Trial By Combat! How long will you survive?");
            Console.WriteLine();

            // disabled to speed up test runs
            
            Console.WriteLine("What is your name?");
            Player.Name = Console.ReadLine();
            Console.Clear();
            

            Weapons weapons = new Weapons();
            weapons.GetWeapon();

            StartGame();

            bool keepPlaying = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine("do you want to play again? (press the 'y' for yes)");
                ConsoleKey bInput = Console.ReadKey().Key;
                if (bInput == ConsoleKey.Y)
                {
                    Console.Clear(); //may need moved
                    StartGame();
                }
                else
                    keepPlaying = false;

            } while (keepPlaying == true);


            //to keep console alive
            Console.WriteLine("\n" + "press any key to exit.");
            Console.ReadKey();
        }


        public static void StartGame()
        {
            //Player player = new Player(); // not sure what the difference is here
            //_ = new Player();
            // _ = new Monster();


            Monster ymonsters = new Monster();
            ymonsters.GetMonster();
            


            //Combat combat = new Combat();
            Console.WriteLine("You see a " + Monster.Name);

            //Console.WriteLine(Player.Name + ", HP " + Player.HP + ", Gold: " + Player.Gold + " - " + Monster.Name + ", HP " + Monster.HP);
            Console.WriteLine();

            //StatBar statbar = new StatBar(); //is it needed ??
            StatBar.DisplayStatBar();
            

            Combat combat = new Combat();
            while (0 < Monster.HP)
            {
               
                //move to seperate method Combat.Menu() ??
                Console.WriteLine("Combat Menu:");
                Console.WriteLine("a) Attack");
                Console.WriteLine("p) 60% Heal Potion\t\t\t" + Potion.HealPotionCount + " available");
                Console.WriteLine("s) Magic Shield Scroll (50 points)\t" + Scroll.MagicShieldScrollCount + " available");
                Console.WriteLine();
                Console.WriteLine("c) Display Character Sheet");



                ConsoleKey aInput = Console.ReadKey().Key;
                if (aInput == ConsoleKey.Escape)
                    Environment.Exit(0);
                if (aInput == ConsoleKey.A)
                    combat.Start();
                if (aInput == ConsoleKey.P)
                    Potion.Heal();
                if (aInput == ConsoleKey.S)
                    Scroll.MagicShield();
                if (aInput == ConsoleKey.C)
                    CharacterSheet.Display();
            }





            // #START loot code
            Player.Gold += Monster.Gold;

            Console.WriteLine();
            Console.WriteLine("you have slain the " + Monster.Name);
            Console.WriteLine("you recieve " + Monster.Gold + " gold, with a total of " + Player.Gold);
            Console.WriteLine();

            Random random = new Random();
            int getLoot = random.Next(0, 10); // should roll 0 through 9, giving 10 chances
            if (getLoot == 0)
            {
                Console.WriteLine("you get a potion"); // potion count code here
                Potion.HealPotionCount += 1;
            }
            else if (getLoot == 1)
            {
                Console.WriteLine("you get a scroll"); // scroll count code here
                Scroll.MagicShieldScrollCount += 1;
            }
            else if (getLoot == 2 | getLoot == 3 | getLoot == 4) // 2, 3 or 4 - 30% chance
            {
                Console.WriteLine("you get gear"); // gear code here - move current gear code into these {} 

                
                int y = random.Next(0, 2); //returns 0, 1 - low number, top number + 1

                string[] gearslot = new string[2];
                gearslot[0] = "head";
                gearslot[1] = "chest";


                GearList gearList = new GearList();
                gearList.GetGear(gearslot[y]);

                
            }
            else
            {
                Console.WriteLine("you get nothing");
            }
            // #END loot code
            

        }
    }
}