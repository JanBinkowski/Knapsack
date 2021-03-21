using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Algorithm
    {
        public Holder KnapSack(int capacity_is, int[] weights, int[] values, int amountOfItems)
        {
            int[,] K = new int[amountOfItems + 1, capacity_is + 1];
            List<int> usedIndices = new List<int>();

            for (int i = 0; i <= amountOfItems; ++i)
            {
                for (int w = 0; w <= capacity_is; ++w)
                {
                    if (i == 0 || w == 0)
                    {
                        K[i, w] = 0;
                    }
                    else if (weights[i - 1] <= w)
                    {
                        K[i, w] = Math.Max(values[i - 1] + K[i - 1, w - weights[i - 1]], K[i - 1, w]);
                    }
                    else
                    {
                        K[i, w] = K[i - 1, w];
                    }
                }
            }

            int result = K[amountOfItems, capacity_is];
            int resultValueForCalculation = result;

            // Create a List of used items  
            List<int> usedItems = new List<int>();

            int W = capacity_is;
            for (int i = amountOfItems; i > 0 && resultValueForCalculation > 0; i--)
            {

                // either the result comes from the top  
                // (K[i-1][w]) or from (values[i-1] + K[i-1]  
                // [w-weights[i-1]]) as in Knapsack table. If  
                // it comes from the latter one/ it means  
                // the item is included.  
                if (resultValueForCalculation == K[i - 1, W])
                    continue;
                else
                {
                    usedItems.Add(i - 1);
                    usedIndices.Add(i);
                    // This item is included.  
                    // Since this weight is included its  
                    // value is deducted  
                    resultValueForCalculation = resultValueForCalculation - values[i - 1];
                    W = W - weights[i - 1];
                }
            }

            int[] usedValues = new int[usedItems.Count];
            int[] usedWeights = new int[usedItems.Count];
            int usedItemsIterator = 0;

            foreach (int i in usedItems)
            {
                usedValues[usedItemsIterator] = values[i];
                usedWeights[usedItemsIterator] = weights[i];
                usedItemsIterator++;
            }

            Holder resultHolder = new Holder(usedValues, usedWeights, usedIndices.ToArray());

            return resultHolder;
        }
    }
}
