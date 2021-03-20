using Microsoft.VisualStudio.TestTools.UnitTesting;
using Knapsack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack.Tests
{
    [TestClass()]
    public class AlgorithmTests
    {
        [TestMethod()]
        public void KnapSackTest()
        {
            ItemGenerator ig = new ItemGenerator(5,1);
            Algorithm algorithm = new Algorithm();

            Assert.AreEqual(9, algorithm.KnapSack(10, ig.getWeights(), ig.getValues(), 5).getResult());
        }

        [TestMethod()]
        public void KnapSackTest2()
        {
            ItemGenerator ig = new ItemGenerator(10,1);
            Algorithm algorithm = new Algorithm();

            Assert.AreEqual(66, algorithm.KnapSack(28, ig.getWeights(), ig.getValues(), 10).getResult());
        }
    }
}