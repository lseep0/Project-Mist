using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingGames
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void FindMethodOK()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Int32 GameId = 21;
            Found = AGame.Find(GameId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameIdFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 21;
            Found = AGame.Find(GameId);

            if (AGame.GameId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 21;
            Found = AGame.Find(GameId);

            if (AGame.Title != "Test Game")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 21;
            Found = AGame.Find(GameId);

            if (AGame.Price != 49.99m)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 21;
            Found = AGame.Find(GameId);

            if (AGame.ReleaseDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsEarlyAccessFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 21;
            Found = AGame.Find(GameId);

            if (AGame.IsEarlyAccess != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}