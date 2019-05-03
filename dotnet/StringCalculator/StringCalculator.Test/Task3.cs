using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace StringCalculator.Test
{
    [TestClass]
    public class Task3
    {
        [TestMethod]
        public void SemiColonSeperated()
        {
            Assert.AreEqual(8, Calculator.Add("//;\n1;3;4"));
        }
        [TestMethod]
        public void DollarSeperated()
        {
            Assert.AreEqual(6, Calculator.Add("//$\n1$2$3"));
        }
        [TestMethod]
        public void AtTheRateSeperated()
        {
            Assert.AreEqual(13, Calculator.Add("//@\n2@3@8"));
        }
    }
}
