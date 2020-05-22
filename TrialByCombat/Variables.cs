using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialByCombat
{
    public static class Variables
    {
        //DiceRoller needs refactored
        //maybe replaced with low / high instead 
        //2d8 --> 2 / 16

        private static int numOfSides = 0;

        public static int GetNumOfSides()
        {
            return numOfSides;
        }

        public static void SetNumOfSides(int value)
        {
            numOfSides = value;
        }

        //number of dice
        private static int nod = 0;

        public static int NumOfDice
        {
            get { return Nod; }
            set { Nod = value; }
        }

        //additive or negative
        private static int aon = 0;

        public static int GetAddOrNeg()
        { return aon; }

        public static void SetAddOrNeg(int value)
        { aon = value; }

        //dice input
        private static string di;

        public static string DiceInput
        {
            get { return di; }
            set { di = value; }
        }

        //total
        private static int tot = 0;

        public static int Total
        {
            get { return Tot; }
            set { Tot = value; }
        }

        public static int Tot { get => Tot1; set => Tot1 = value; }
        public static int Tot1 { get => Tot2; set => Tot2 = value; }
        public static int Tot2 { get => tot; set => tot = value; }
        public static int Nod { get => nod; set => nod = value; }
    }
}