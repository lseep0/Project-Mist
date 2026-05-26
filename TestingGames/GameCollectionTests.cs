using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingGames
{
    [TestClass]
    public class GameCollectionTests
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            Assert.IsNotNull(AllGames);
        }

        [TestMethod]
        public void GameListOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            List<clsGame> TestList = new List<clsGame>();
            clsGame TestItem = new clsGame();

            TestItem.GameId = 1;
            TestItem.Title = "Cyberpunk 2077";
            TestItem.Price = 49.99m;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.IsEarlyAccess = false;

            TestList.Add(TestItem);
            AllGames.GameList = TestList;
            Assert.AreEqual(AllGames.GameList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            Int32 SomeCount = 1; // Change this to match your actual database row count!
            Assert.AreEqual(AllGames.Count, SomeCount);
        }

    }
}