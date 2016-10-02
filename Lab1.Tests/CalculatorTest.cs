using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace Lab1.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Multiply()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Multiply(2, 5);

            Assert.AreEqual(10, result);
        }
    }
}
