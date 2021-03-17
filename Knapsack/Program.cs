using System;
using System.Collections.Generic;

namespace Knapsack
{
   

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of items: ");
            int amountOfItems = Convert.ToInt32(Console.ReadLine());
            Console.Write("Capacity: ");
            int capacity_is = Convert.ToInt32(Console.ReadLine());
            Console.Write("RNG seed: ");
            int rngSeed = Convert.ToInt32(Console.ReadLine());

            ItemGenerator generator = new(amountOfItems,rngSeed);
            

            generator.showItems();
            
            int[] values = generator.getValues();
            int[] weights = generator.getWeights();

            Algorithm algo = new();
            
          Console.WriteLine( "Solution: " + algo.KnapSack(capacity_is, weights,values, amountOfItems));

        }
    }
}