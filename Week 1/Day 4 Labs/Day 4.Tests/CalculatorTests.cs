using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_4_Labs;

namespace Day_4.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            //Arrange
            var calc = new Calculator();
            //Act
            var result = calc.AddNumbers(0, 0);
            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
