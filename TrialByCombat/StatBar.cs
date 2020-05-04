using System;

namespace TrialByCombat
{
    public class StatBar
    {
        public static void DisplayStatBar()
        {  
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(Player.Name + ", HP " + Player.HP + ", Gold: " + Player.Gold + "\t\t\t\t" + Monster.Name + ", HP " + Monster.HP);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine();
        }
    }
}
