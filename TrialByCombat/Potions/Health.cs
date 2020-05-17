using System;

namespace TrialByCombat.Potions
{
    static class HealthPotion
    {
        public static int Quantity { get; set; } = 10;

        public static void Cast()
        {
            if (Quantity >= 1) // you have potions available
            {
                if (Player.HPmax == Player.HP) // you are at max HP
                {
                    Console.Clear();
                    Console.WriteLine("You are already as max health!");
                }
                else
                {
                    Quantity--;
                    int oldHP = Player.HP;
                    int tooHeal = Convert.ToInt32((Player.HPmax / 100) * 60); // Convert.ToInt32 to prevent half numbers like 59.3 hp
                    if ((Player.HP + tooHeal) > Player.HPmax) // if the potion will heal over max hp
                    {
                        Player.HP = Player.HPmax; // set hp to max
                    }
                    else // if potion will not over heal
                    {
                        Player.HP += tooHeal; // add heal amount to current hp
                    }
                    Console.Clear();
                    Console.WriteLine("you have used a 60% heal potion, you gained " + (Player.HP - oldHP) + "hp,  you are now at " + Player.HP + "hp");
                }
            }
            else // you have no ppotions available
            {
                Console.Clear();
                Console.WriteLine("you have no Health Potions available");
            }
        }
    }
}