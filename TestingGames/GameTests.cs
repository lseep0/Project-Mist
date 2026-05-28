using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingGames
{
    [TestClass]
    public class GameTests
    {
        string title = "Cyberpunk 2077";
        string price = "49.99";
        string releaseDate = "10/12/2020";

        [TestMethod]
        public void ValidMethodOK()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            Error = AGame.Valid(title, price, releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Int32 GameId = 1;
            Found = AGame.Find(GameId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameIdFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 1;
            Found = AGame.Find(GameId);

            if (AGame.GameId != 1) { OK = false; }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 1;
            Found = AGame.Find(GameId);

            if (AGame.Title != "Cyberpunk 2077") { OK = false; }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 1;
            Found = AGame.Find(GameId);

            if (AGame.Price != 49.99m) { OK = false; }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 1;
            Found = AGame.Find(GameId);

            if (AGame.ReleaseDate != Convert.ToDateTime("10/12/2020")) { OK = false; }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsEarlyAccessFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 1;
            Found = AGame.Find(GameId);

            if (AGame.IsEarlyAccess != false) { OK = false; }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinBoundary()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testTitle = "A"; 
            Error = AGame.Valid(testTitle, price, releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testTitle = "A".PadRight(51, 'A'); 
            Error = AGame.Valid(testTitle, price, releaseDate);
            Assert.AreNotEqual(Error, ""); 
        }

        [TestMethod]
        public void TitleInvalidNull()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testTitle = null;
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testPrice = "abc"; 
            Error = AGame.Valid(title, testPrice, releaseDate);
            Assert.AreNotEqual(Error, ""); 
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testPrice = "99999.00"; 
            Error = AGame.Valid(title, testPrice, releaseDate);
            Assert.AreNotEqual(Error, ""); 
        }

        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testDate = "01/01/1900"; 
            Error = AGame.Valid(title, price, testDate);
            Assert.AreNotEqual(Error, ""); 
        }

        [TestMethod]
        public void ReleaseDateBoundaryToday()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testDate = DateTime.Now.Date.ToString(); 
            Error = AGame.Valid(title, price, testDate);
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void ReleaseDateInvalidData()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testDate = "not-a-date"; 
            Error = AGame.Valid(title, price, testDate);
            Assert.AreNotEqual(Error, ""); 
        }
    }
}