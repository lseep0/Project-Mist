using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstGameCollection
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
            TestItem.Title = "Test Game";
            TestItem.Price = 19.99m;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.IsEarlyAccess = false;

            TestList.Add(TestItem);
            AllGames.GameList = TestList;

            Assert.AreEqual(AllGames.GameList, TestList);
        }

        [TestMethod]
        public void ThisGamePropertyOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            clsGame TestItem = new clsGame();

            TestItem.GameId = 1;
            TestItem.Title = "Test Game";
            TestItem.Price = 19.99m;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.IsEarlyAccess = false;

            AllGames.ThisGame = TestItem;

            Assert.AreEqual(AllGames.ThisGame, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            List<clsGame> TestList = new List<clsGame>();
            clsGame TestItem = new clsGame();

            TestItem.GameId = 1;
            TestItem.Title = "Test Game";
            TestItem.Price = 19.99m;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.IsEarlyAccess = false;

            TestList.Add(TestItem);
            AllGames.GameList = TestList;

            Assert.AreEqual(AllGames.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            clsGame TestItem = new clsGame();
            Int32 PrimaryKey = 0;

            TestItem.Title = "Test Add Game";
            TestItem.Price = 15.99m;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.IsEarlyAccess = true;

            AllGames.ThisGame = TestItem;
            PrimaryKey = AllGames.Add();
            TestItem.GameId = PrimaryKey;

            AllGames.ThisGame.Find(PrimaryKey);
            Assert.AreEqual(AllGames.ThisGame.GameId, TestItem.GameId);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            clsGame TestItem = new clsGame();
            Int32 PrimaryKey = 0;

            TestItem.Title = "Test Add Game";
            TestItem.Price = 15.99m;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.IsEarlyAccess = true;
            AllGames.ThisGame = TestItem;
            PrimaryKey = AllGames.Add();
            TestItem.GameId = PrimaryKey;

            TestItem.Title = "Test Update Game";
            TestItem.Price = 25.99m;
            TestItem.IsEarlyAccess = false;
            AllGames.ThisGame = TestItem;

            AllGames.Update();

            AllGames.ThisGame.Find(PrimaryKey);
            Assert.AreEqual(AllGames.ThisGame.Title, TestItem.Title);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            clsGame TestItem = new clsGame();
            Int32 PrimaryKey = 0;

            TestItem.Title = "Test Delete Game";
            TestItem.Price = 15.99m;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.IsEarlyAccess = true;
            AllGames.ThisGame = TestItem;
            PrimaryKey = AllGames.Add();
            TestItem.GameId = PrimaryKey;

            AllGames.ThisGame.Find(PrimaryKey);
            AllGames.Delete();

            Boolean Found = AllGames.ThisGame.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByTitleMethodOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            clsGameCollection FilteredGames = new clsGameCollection();

            FilteredGames.ReportByTitle("");

            Assert.AreEqual(AllGames.Count, FilteredGames.Count);
        }

        [TestMethod]
        public void ReportByTitleNoneFound()
        {
            clsGameCollection FilteredGames = new clsGameCollection();

            FilteredGames.ReportByTitle("xxxxxxxxxxxxxxx");

            Assert.AreEqual(0, FilteredGames.Count);
        }
    }
}