using System;

namespace TrialByCombat.Potions
{
    public partial class Potion
    {
        public static void Shield()
        {
            Player.HP += 50;
            Console.WriteLine();
            Console.WriteLine("you have used a 50hp heal potion, you are now at " + Player.HP + "hp");
            Console.WriteLine();
        }
    }
}