using System;
using System.Collections.Generic;

namespace Knapsack
{
    public class ItemGenerator
    {
        private readonly int[] weights;
        private readonly int[] values;
        private readonly int amountOfItems;

        public ItemGenerator(int amount)
        {
            var rand = new RandomNumberGenerator(1);
            amountOfItems = amount;
            values = new int[amount];
            weights = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                weights[i] = rand.nextInt(1, 29);
               // values[i] = rand.nextInt(1, 29);
            }
            for (int i = 0; i < amount; i++)
            {
                //weights[i] = rand.nextInt(1, 29);
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
        /*
        public void deleteItem(int itemId)
        {
            weights[itemId] = 0;
            values[itemId] = 0;
        }
        */
        public int[] getWeights()
        {
            return weights;
        }

        public int[] getValues()
        {
            return values;
        }
    }

    /*
    public class Algorithm
    {
        public void fraction(int[] weight, int[] values)
        {
            double a;
            for (int i=0; i<weight.Length; i++)
            {
                a = (double)weight[i] / values[i];           
            }
        }
    }
    */

    public class Algorithm
    {        
        private static int getMaxIndex(int[] weight, int[] values)
        {
            int max_i = 0;
            double max = 0;
            for (int i = 0; i < weight.Length; i++)
            {
                if (weight[i] != 0 && (double)weight[i] / values[i] > max)
                {
                    max = (double)weight[i] / values[i];
                    max_i = i;
                }
            }
            return max_i;
        }
        public double getOptimalValue(int capacity_is, int[] values, int[] weight)
        {
            double value = 0.0;
            for (int i = 0; i < weight.Length; i++)
            {
                if (capacity_is == 0)
                    return value;
                int index = getMaxIndex(weight, values);
                int a = Math.Min(capacity_is, weight[index]);
                value += a * (double)weight[index] / values[index];
                weight[index] -= a;
                capacity_is -= a;
            }
            return value;
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
            //            Console.WriteLine("Hello World!");

            ItemGenerator generator = new(amountOfItems);
            

            generator.showItems();
            
            int[] values = generator.getValues();
            int[] weights = generator.getWeights();

            Algorithm algo = new();
            
          Console.Write( "Solution: "+algo.getOptimalValue(capacity_is, weights,values));
          
            /*
            foreach (var item in weights)
            {
                Console.WriteLine(item.ToString());
            }
            */
        }
    }
}