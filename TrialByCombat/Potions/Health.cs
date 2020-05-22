using System;

namespace TrialByCombat.Potions
{
    static class HealthPotion
    {
        public static int Quantity { get; set; } = 10;

        public static void Cast(Player player)
        {
            if (Quantity >= 1) // you have potions available
            {
                if (player.HealthMax == player.Health) // you are at max HP
                {
                    Console.Clear();
                    Console.WriteLine("You are already as max health!");
                }
                else
                {
                    Quantity--;
                    int oldHP = player.Health;
                    int tooHeal = Convert.ToInt32((player.HealthMax / 100) * 60); // Convert.ToInt32 to prevent half numbers like 59.3 hp
                    if ((player.Health + tooHeal) > player.HealthMax) // if the potion will heal over max hp
                    {
                        player.Health = player.HealthMax; // set hp to max
                    }
                    else // if potion will not over heal
                    {
                        player.Health += tooHeal; // add heal amount to current hp
                    }
                    Console.Clear();
                    Console.WriteLine("you have used a 60% heal potion, you gained " + (player.Health - oldHP) + "hp,  you are now at " + player.Health + "hp");
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