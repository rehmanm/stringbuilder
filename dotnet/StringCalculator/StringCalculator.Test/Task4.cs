using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace StringCalculator.Test
{
    [TestClass]
    public class Task4
    {
        [TestMethod]
        public void NegativeNumberNotAllowedException()
        {
            Assert.ThrowsException<NegativeNumberNotAllowedException>(() => Calculator.Add("-1,3"));
        }
    }
}
