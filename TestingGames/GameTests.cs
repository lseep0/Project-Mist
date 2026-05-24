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
        public void GameIdPropertyOK()
        {
            clsGame AGame = new clsGame();
            Int32 TestData = 1;
            AGame.GameId = TestData;
            Assert.AreEqual(AGame.GameId, TestData);
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

        [TestMethod]
        public void ReleaseDatePropertyOK()
        {
            clsGame AGame = new clsGame();
            // Create some test date data
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AGame.ReleaseDate = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AGame.ReleaseDate, TestData);
        }

        [TestMethod]
        public void IsEarlyAccessPropertyOK()
        {
            clsGame AGame = new clsGame();
            bool TestData = true;
            AGame.IsEarlyAccess = TestData;
            Assert.AreEqual(AGame.IsEarlyAccess, TestData);
        }
    }
}