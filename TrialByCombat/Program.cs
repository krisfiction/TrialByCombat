using System;
using TrialByCombat.Scrolls;
using TrialByCombat.Potions;
using System.Collections.Generic;

namespace TrialByCombat
{
    static class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();


            Inventory InventoryList = new Inventory();
            InventoryList.Initialize();

           
            Prefix.Initialize();
            Suffix.Initialize();


            //todo get starter weapon
            Generate.Weapon();
            Inventory.EquipStarterWeapon(player);


            Console.WriteLine("Welcome to the Trial By Combat! How long will you survive?");
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            player.Name = Console.ReadLine();
            Console.Clear();



            //maybe lower item count and use as random inventory to choose weapon and gear
            // testing
            int f = 0;
            do
            {
                Generate.Weapon();
                //Generate.Armor();
                f++;
            } while (f < 25);




            StartGame(player);
           

            bool keepPlaying = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine("do you want to play again? (press the 'y' for yes)");
                ConsoleKey bInput = Console.ReadKey().Key;
                if (bInput == ConsoleKey.Y)
                {
                    Console.Clear(); //may need moved
                    StartGame(player);
                }
                else
                    keepPlaying = false;

            } while (keepPlaying == true);


            //to keep console alive
            Console.WriteLine("\npress any key to exit.");
            Console.ReadKey();
        }


        public static void StartGame(Player player)
        {
            Monster monster = new Monster();
            // monster.GetMonster();
            Generate.Monster(monster);


            Console.WriteLine("You see a " + monster.Name);

            Console.WriteLine();



            Combat combat = new Combat();



            while (0 < monster.Health)
            {
                StatBar.DisplayStatBar(player, monster);

                //move to seperate method Combat.Menu() ??
                Console.WriteLine("Combat Menu:");
                Console.WriteLine("a) Attack");
                Console.WriteLine("h) 60% Heal Potion\t\t\t" + HealthPotion.Quantity + " available");
                Console.WriteLine("s) Magic Shield Scroll (50 points)\t" + Scroll.MagicShieldScrollCount + " available");
                Console.WriteLine("d) Death Scroll (Instant Kill)\t\t" + Scroll.DeathScrollCount + " available");
                Console.WriteLine();
                Console.WriteLine("c) Character Sheet");
                Console.WriteLine("i) Inventory");


                ConsoleKey aInput = Console.ReadKey().Key;
                if (aInput == ConsoleKey.Escape)
                {
                    Console.WriteLine("x"); //Escape key seems to delete the first character of the next line
                    Console.WriteLine("are you sure you want to Quit playing? (press Y for yes");
                   
                    ConsoleKey bInput = Console.ReadKey().Key;
                    if (bInput == ConsoleKey.Y)
                    {
                        Environment.Exit(0);
                    }
                }
                if (aInput == ConsoleKey.A)
                    combat.Start(player, monster);
                if (aInput == ConsoleKey.H)
                    HealthPotion.Cast(player);
                if (aInput == ConsoleKey.S)
                {
                    Scroll.MagicShield(player);
                    combat.MonsterAttack(player, monster); // attack of opportunity ??
                }
                if (aInput == ConsoleKey.C)
                    CharacterSheet.Display(player);
                if (aInput == ConsoleKey.D)
                {
                    Scroll.Death(monster);
                    combat.MonsterAttack(player, monster); // attack of opportunity ?? - may need removed - monster should be dead so it is redundant
                }
                if (aInput == ConsoleKey.I)
                    Inventory.Display(player);
            }

            Console.WriteLine("you have slain the " + monster.Name);
            Loot.Roll(player, monster);
            //Generate.Armor();
        }
    }
}