using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingGames
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsGame AGame = new clsGame();

            Assert.IsNotNull(AGame);
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            clsGame AGame = new clsGame();
            string TestData = "Elden Ring";

            AGame.Title = TestData;

            Assert.AreEqual(AGame.Title, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsGame AGame = new clsGame();
            decimal TestData = 59.99m;

            AGame.Price = TestData;

            Assert.AreEqual(AGame.Price, TestData);
        }
    }
}