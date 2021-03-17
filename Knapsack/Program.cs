using System;
using System.Collections.Generic;

namespace Knapsack
{
   

    

    class Program
    {
        static void Main(string[] args)
        {
            string input_n;
            string input_c;
            string input_rng;
            Console.Write("Number of items: ");
            input_n = Console.ReadLine();
            Console.Write("Capacity: ");
            input_c = Console.ReadLine();
            Console.Write("RNG seed: ");
            input_rng = Console.ReadLine();

            //check if user inputs numbers
            if ((!IsNumber(input_n)) || (!IsNumber(input_c)) || (!IsNumber(input_rng)))
            {
                Console.WriteLine("One of your input is not a number");
                System.Environment.Exit(0);
            }

            int amountOfItems = Convert.ToInt32(input_n);
            int capacity_is = Convert.ToInt32(input_c);
            int rngSeed = Convert.ToInt32(input_rng);

            ItemGenerator generator = new(amountOfItems, rngSeed);


            generator.showItems();
            
            int[] values = generator.getValues();
            int[] weights = generator.getWeights();

            Algorithm algo = new();
            
          Console.WriteLine( "Solution: " + algo.KnapSack(capacity_is, weights,values, amountOfItems));

        }

        public static bool IsNumber(string input)
        {
            int value;
            if (int.TryParse(input, out value))
                return true;
            else
                return false;
        }
    }
}