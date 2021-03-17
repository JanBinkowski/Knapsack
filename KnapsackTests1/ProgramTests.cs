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
    public class ProgramTests
    {
        [TestMethod()]
        public void IsNumberTest()
        {
            Assert.IsFalse(Program.IsNumber("test"));
        }

        [TestMethod()]
        public void IsNumberTest2()
        {
            Assert.IsTrue(Program.IsNumber("3"));
        }
    }
}