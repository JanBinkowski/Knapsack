using System;
using System.Collections.Generic;

namespace Knapsack
{
    public class ItemGenerator
    {
        private readonly int[] weights;
        private readonly int[] values;
        private readonly int amountOfItems;

        public ItemGenerator(int amount, int userInputSeed)
        {
            var rand = new RandomNumberGenerator(userInputSeed);
            amountOfItems = amount;
            values = new int[amount];
            weights = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                weights[i] = rand.nextInt(1, 29);
            }
            for (int i = 0; i < amount; i++)
            {
                 values[i] = rand.nextInt(1, 29);
            }
        }

        public void showItems()
        {
            for (int i = 0; i < amountOfItems; i++)
            {
                Console.WriteLine("Item" + (i + 1) + " weight: " + weights[i] + " value: " + values[i]);
            }
        }
        public int[] getWeights()
        {
            return weights;
        }

        public int[] getValues()
        {
            return values;
        }
    }

    public class Algorithm
    {
        public int KnapSack(int capacity_is, int[] weights, int[] values, int amountOfItems)
        {
            int[,] K = new int[amountOfItems + 1, capacity_is + 1];

            for (int i = 0; i <= amountOfItems; ++i)
            {
                for (int w = 0; w <= capacity_is; ++w)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (weights[i - 1] <= w)
                        K[i, w] = Math.Max(values[i - 1] + K[i - 1, w - weights[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            return K[amountOfItems, capacity_is];
        }
    }

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