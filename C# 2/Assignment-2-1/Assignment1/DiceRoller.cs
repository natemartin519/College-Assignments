// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 1
// DiceRoller.cs

using System;

namespace Assignment1
{
    public class DiceRoller
    {
        private const int NUMBER_OF_DICE_ROLLS = 36000;
        private const int ARRAY_SIZE = 11;

        // Used to place the rolled dice sum in the correct array location
        // 1 for the array offset, plus 1 because you can't roll a one with two dice
        private const int TALLY_OFFSET = 2;

        private static Random randomNumber = new Random();



        public static void Main(string[] args)
        {
            int[] diceSumTally = new int[ARRAY_SIZE];


            for (int x = 0; x < NUMBER_OF_DICE_ROLLS; x++)
            {          
                // Add the dice roll result to the counter array
                diceSumTally[(RollDice() - TALLY_OFFSET)]++;
            }


            Console.WriteLine("{0, 3}{1, 11}{2, 12}","Sum", "Frequency", "Percentage");
            for (int x = 0; x < ARRAY_SIZE; x++)
            {
                Console.WriteLine("{0, 3}{1, 11}{2, 12:P0}", (x + TALLY_OFFSET), diceSumTally[x], (double)diceSumTally[x] / (double)NUMBER_OF_DICE_ROLLS);
            }


            Console.Read();
        }


        // Returns the result of two rolled six sided dice
        private static int RollDice()
        {
            int dieOne = randomNumber.Next(1,7);
            int dieTwo = randomNumber.Next(1,7);

            return dieOne + dieTwo;
        }
    }
}
