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
            Console.WriteLine("Welcome to the Trial By Combat! How long will you survive?");
            Console.WriteLine();

            Console.WriteLine("What is your name?");
            Player.Name = Console.ReadLine();
            Console.Clear();

            Inventory InventoryList = new Inventory(); //TODO inventory list
            InventoryList.Initialize();

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
            Console.WriteLine("\npress any key to exit.");
            Console.ReadKey();
        }


        public static void StartGame()
        {
            Monster ymonsters = new Monster();
            ymonsters.GetMonster();


            Console.WriteLine("You see a " + Monster.Name);

            Console.WriteLine();



            Combat combat = new Combat();
            while (0 < Monster.HP)
            {
                StatBar.DisplayStatBar();

                //move to seperate method Combat.Menu() ??
                Console.WriteLine("Combat Menu:");
                Console.WriteLine("a) Attack");
                Console.WriteLine("h) 60% Heal Potion\t\t\t" + HealthPotion.Quantity + " available");
                Console.WriteLine("s) Magic Shield Scroll (50 points)\t" + Scroll.MagicShieldScrollCount + " available");
                Console.WriteLine("d) Death Scroll (Instant Kill)\t\t" + Scroll.DeathScrollCount + " available");
                Console.WriteLine();
                Console.WriteLine("c) Character Sheet");
                

                ConsoleKey aInput = Console.ReadKey().Key;
                if (aInput == ConsoleKey.Escape)
                    Environment.Exit(0);
                if (aInput == ConsoleKey.A)
                    combat.Start();
                if (aInput == ConsoleKey.H)
                    HealthPotion.Cast();
                if (aInput == ConsoleKey.S)
                {
                    Scroll.MagicShield();
                    combat.MonsterAttack(); // attack of opportunity ??
                }
                if (aInput == ConsoleKey.C)
                    CharacterSheet.Display();
                if (aInput == ConsoleKey.D)
                {
                    Scroll.Death();
                    combat.MonsterAttack(); // attack of opportunity ?? - may need removed - monster should be dead so it is redundant
                }
                if (aInput == ConsoleKey.I)
                    Inventory.Display();
            }

            Console.WriteLine("you have slain the " + Monster.Name);
            Generate.Armor();

        }
    }
}