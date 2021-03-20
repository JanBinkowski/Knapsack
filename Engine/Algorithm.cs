using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
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
}
