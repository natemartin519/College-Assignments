// Nathan Martin
// PROG1720 - Visual C#.NET I
// Assignment 4
// WorldPopulation.cs

using System;

namespace Assignment4
{
    internal class WorldPopulation
    {

        // Auto-Implemented Properties
        public long population { set; get; }
        public double growthRate { set; get; }

        // Constructors
        public WorldPopulation(long constructPopulation, double constructGrothRate) 
        {
            population = constructPopulation;
            growthRate = constructGrothRate;
        }

        // Calculations
        public void PrintPopulationGrowth(int years) 
        {
            Console.WriteLine("{0, -8}{1, -20}{2}", "Year", "Population", "Change");

            for (int x = 1; x <= years; x++)
            {
                long populationThisYear = (long)(population * Math.Pow((1 + growthRate), x));
                long populationChange = (long)(populationThisYear - (population * Math.Pow((1 + growthRate), x - 1)));

                Console.WriteLine("{0, -8}{1,-20:#,#}{2:#,#}", x, populationThisYear, populationChange);
            }
        }

        public int FindPopulationDoubleYear()
        {
            int yearCounter = 0;
            bool doubledFlag = false;

            do{
                yearCounter++;

                if ((population * Math.Pow((1 + growthRate), yearCounter)) >= (population * 2))
                {
                    doubledFlag = true;
                }
            } while (doubledFlag == false);

            return yearCounter;
        }
    }
}
