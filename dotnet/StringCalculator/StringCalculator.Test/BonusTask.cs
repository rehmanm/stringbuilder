using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace StringCalculator.Test
{
    [TestClass]
    public class BonusTask
    {
        [TestMethod]
        public void IgnoreLargerThan1000()
        {
            Assert.AreEqual(2, Calculator.Add("2,1001"));
        }
        [TestMethod]
        public void DelimitersWithArbitraryLength()
        {
            Assert.AreEqual(6, Calculator.Add("//***\n1***2***3"));
        }
        [TestMethod]
        public void MultipleDelimiters()
        {
            Assert.AreEqual(6, Calculator.Add("//$,@\n1$2@3"));
        }
        [TestMethod]
        public void ArbitraryWithMultipleDelimiters()
        {
            Assert.AreEqual(10, Calculator.Add("//***,$,@\n1$2@3***4"));
        }
    }
}
