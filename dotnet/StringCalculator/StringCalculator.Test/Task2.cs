using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Test
{
    [TestClass]
    public class Task2
    {
        [TestMethod]
        public void HandleNewLines1()
        {
            Assert.AreEqual(Model.Calculator.Add("1\n,2,3"), 6);
        }

        [TestMethod]
        public void HandleNewLines2()
        {
            Assert.AreEqual(Model.Calculator.Add("1,\n2,4"), 7);
        }
    }
}
