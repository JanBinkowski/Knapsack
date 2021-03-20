using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Holder
    {
        //Result item statistics
        private int[] usedValues;
        private int[] usedWeights;
        private int resultWeight = 0;
        private int resultValue = 0;

        public Holder(int[] values, int[] weights)
        {
            usedValues = values;
            usedWeights = weights;
            resultValue = 0;
            resultWeight = 0;

            int amount = usedWeights.Length;

            for (int i = 0; i < amount; i++)
            {
                resultWeight += weights[i];
                resultValue += values[i];
            }
        }

        public int[] getUsedWeights()
        {
            return usedWeights;
        }

        public int[] getUsedValues()
        {
            return usedValues;
        }

        public int getResult()
        {
            return resultValue;
        }

        public int getResultWeight()
        {
            return resultWeight;
        }

        //Print used items;
        public void printUsesItemsStats()
        {
            for (int i = 0; i < usedValues.Length; i++)
            {
                Console.WriteLine("Used item stats:" + " weight: " + usedWeights[i] + " value: " + usedValues[i]);
            }
        }
    }
}
