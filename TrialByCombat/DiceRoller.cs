using System;

namespace TrialByCombat
{
    class DiceRoller
    {
        public void Start(string dicetoroll)
        {
            Variables.Total = 0; //reset 
            //should i reset all variables ??


            Variables.DiceInput = dicetoroll;

            SplitInput(Variables.DiceInput);
        }

        public void SplitInput(string die_input)
        {

            string[] first_split = die_input.Split('d');
            Variables.NumOfDice = Int32.Parse(first_split[0]);

            if (die_input.Contains("+")) //2d6+7
            {
                string[] second_split = first_split[1].Split('+');
                Variables.SetNumOfSides(Int32.Parse(second_split[0]));
                Variables.SetAddOrNeg(Int32.Parse(second_split[1]));

                Roll();

            }
            else if (die_input.Contains("-")) //2d6-7
            {
                string[] second_split = first_split[1].Split('-');
                Variables.SetNumOfSides(Int32.Parse(second_split[0]));
                Variables.SetAddOrNeg(Int32.Parse(second_split[1]));

                Roll();
            }
            else //2d6
            {
                Variables.NumOfDice = Int32.Parse(first_split[0]);
                Variables.NumOfDice = Int32.Parse(first_split[0]);
                Variables.SetNumOfSides(Int32.Parse(first_split[1]));

                Roll();
            }
        }

        public void Roll()
        {
            Random Random = new Random();

            for (int i = 0; i < Variables.NumOfDice; i++)
            {
                Variables.Total += Random.Next(1, Variables.GetNumOfSides());
            }

            if (Variables.DiceInput.Contains("+"))
            {
                //Console.WriteLine("plus");
                Variables.Total += Variables.GetAddOrNeg();
            }
            else if (Variables.DiceInput.Contains("-"))
            {
                //Console.WriteLine("negative");
                Variables.Total -= Variables.GetAddOrNeg();
            }

            // Console.WriteLine("this is it -- total: " + Variables.Total);

        }
    }
}