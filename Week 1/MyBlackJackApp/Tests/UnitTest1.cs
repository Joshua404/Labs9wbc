using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyBlackJackApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var game = new Game();
            var result = game.DealNewHand(cardsInHand);
            Assert.AreEqual(2, result);
        }
    }
}
