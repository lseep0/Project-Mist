using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingGames
{
    [TestClass]
    public class GameTests
    {
        // --- PRACTICAL 10: VALIDATION TEST DATA ---
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

        // --- PRACTICAL 9: DATABASE TESTS ---
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
            string testTitle = "A"; // Boundary
            Error = AGame.Valid(testTitle, price, releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testTitle = "A".PadRight(51, 'A'); // 51 chars
            Error = AGame.Valid(testTitle, price, releaseDate);
            Assert.AreNotEqual(Error, ""); // Should return error
        }

        [TestMethod]
        public void TitleInvalidNull()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testTitle = null;
            // This will likely trigger an exception, 
            // you can use Assert.ThrowsException<NullReferenceException>(() => AGame.Valid(testTitle, price, releaseDate));
            // Or just check that your code handles it gracefully!
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testPrice = "abc"; // Invalid type
            Error = AGame.Valid(title, testPrice, releaseDate);
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testPrice = "99999.00"; // Too high
            Error = AGame.Valid(title, testPrice, releaseDate);
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testDate = "01/01/1900"; // Too old
            Error = AGame.Valid(title, price, testDate);
            Assert.AreNotEqual(Error, ""); // Should return error
        }

        [TestMethod]
        public void ReleaseDateBoundaryToday()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testDate = DateTime.Now.Date.ToString(); // Exactly today
            Error = AGame.Valid(title, price, testDate);
            Assert.AreEqual(Error, ""); // Should be valid
        }

        [TestMethod]
        public void ReleaseDateInvalidData()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string testDate = "not-a-date"; // Garbage text
            Error = AGame.Valid(title, price, testDate);
            Assert.AreNotEqual(Error, ""); // Should return error
        }
    }
}