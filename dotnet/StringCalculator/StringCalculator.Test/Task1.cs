using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace StringCalculator.Test
{
    [TestClass]
    public class Task1
    {
        [TestMethod]
        public void EmptyStringShouldReturnZero()
        {
            Assert.AreEqual(0, Calculator.Add(""));
        }

        [TestMethod]
        public void ReturnTypeIsInt()
        {
            Assert.IsInstanceOfType(Calculator.Add("1,2,5"), typeof(Int32));
        }

        [TestMethod]
        public void TestResult()
        {
            Assert.AreEqual(8, Calculator.Add("1,2,5"));
        }


    }
}
