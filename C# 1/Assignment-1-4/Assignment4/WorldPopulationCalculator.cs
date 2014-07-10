// Nathan Martin
// PROG1720 - Visual C#.NET I
// Assignment 4
// WorldPopulationCalculator.cs

using System;

namespace Assignment4
{
    class WorldPopulationCalculator
    {
        static void Main(string[] args)
        {
            const long POPULATION = 6962259595;
            const double GROTH_RATE = 0.012;
            const int NUMBER_OF_YEARS = 25;

            WorldPopulation currentPopulation = new WorldPopulation(POPULATION, GROTH_RATE);

            currentPopulation.PrintPopulationGrowth(NUMBER_OF_YEARS);

            Console.WriteLine("At the current rate of growth the population will double by year {0}.", currentPopulation.FindPopulationDoubleYear());
            
            Console.Read();
        }
    }
}
