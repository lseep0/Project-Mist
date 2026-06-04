using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Testing1
{
    [TestClass]
    public class tstUsersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsUsersCollection AllUsers = new clsUsersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllUsers);
        }
        [TestMethod]
        public void UsersListOK()
        {
            //create an instance of the class we want to create
            clsUsersCollection AllUsers = new clsUsersCollection();
            //create some test data to assign to the property
            List<clsUsers> TestList = new List<clsUsers>();
            //add an item to the list
            clsUsers TestItem = new clsUsers();
            TestItem.UserID = 1;
            TestItem.UserName = "John Pork";
            TestItem.Password = "12345678";
            TestItem.UserEmail = "JohnPorky@gmail.com";
            TestItem.JoinedDate = DateTime.Now.Date;
            TestItem.Active = true;
            TestItem.UserEmailVerified = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UsersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.UsersList, TestList);

        }

        [TestMethod]
        public void ThisUsersPropertyOK()
        {
            //create an instance of the class we want to create
            clsUsersCollection AllUsers = new clsUsersCollection();
            //create some test data to assign to the property
            clsUsers TestUser = new clsUsers();
            TestUser.UserID = 1;
            TestUser.UserName = "John Pork";
            TestUser.Password = "12345678";
            TestUser.UserEmail = "JohnPorky@gmail.com";
            TestUser.JoinedDate = DateTime.Now.Date;
            TestUser.Active = true;
            TestUser.UserEmailVerified = true;
            AllUsers.ThisUsers = TestUser;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUsers, TestUser);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsUsersCollection AllUsers = new clsUsersCollection();
            //create some test data to assign to the property
            List<clsUsers> TestList = new List<clsUsers>();
            //add an item to the list
            clsUsers TestItem = new clsUsers();
            TestItem.UserID = 1;
            TestItem.UserName = "John Pork";
            TestItem.Password = "12345678";
            TestItem.UserEmail = "JohnPorky@gmail.com";
            TestItem.JoinedDate = DateTime.Now;
            TestItem.Active = true;
            TestItem.UserEmailVerified = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UsersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsUsersCollection AllUsers = new clsUsersCollection();
            //create some test data to assign to the property
            clsUsers TestItem = new clsUsers();
            Int32 PrimaryKey = 0;
            TestItem.UserID = 1;
            TestItem.UserName = "John Pork";
            TestItem.Password = "12345678";
            TestItem.UserEmail = "JohnPorky@gmail.com";
            TestItem.JoinedDate = DateTime.Now;
            TestItem.Active = true;
            TestItem.UserEmailVerified = true;
            //set ThisUsers to the test data
            AllUsers.ThisUsers = TestItem;
            //add the record
            PrimaryKey = AllUsers.Add();
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //find the record
            AllUsers.ThisUsers.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUsers, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsUsersCollection AllUsers = new clsUsersCollection();
            //create some test data to assign to the property
            clsUsers TestItem = new clsUsers();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserName = "vigil";
            TestItem.Password = "12345678";
            TestItem.UserEmail = "vigil@gmail.com";
            TestItem.UserEmailVerified = true;
            TestItem.Active = true;
            TestItem.JoinedDate = DateTime.Now;
            //set ThisUsers to the test data
            AllUsers.ThisUsers = TestItem;
            //add the record
            PrimaryKey = AllUsers.Add();
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //modify the test data
            TestItem.UserName = "Jane Pork";
            TestItem.Password = "87654321";
            TestItem.UserEmail = "JanePork@gmail.com";
            TestItem.UserEmailVerified = false;
            TestItem.Active = false;
            //set the record based on the new test data
            AllUsers.ThisUsers = TestItem;
            //update the record
            AllUsers.Update();
            //find the record
            AllUsers.ThisUsers.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUsers, TestItem);



        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsUsersCollection AllUsers = new clsUsersCollection();
            //create some test data to assign to the property
            clsUsers TestItem = new clsUsers();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserName = "Jake ";
            TestItem.Password = "12345678";
            TestItem.UserEmail = "testeremail@gmail.com";
            TestItem.UserEmailVerified = true;
            TestItem.Active = true;
            TestItem.JoinedDate = DateTime.Now;
            TestItem.UserID = 1;
            //  set ThisUsers to the test data
            AllUsers.ThisUsers = TestItem;
            //add the record
            PrimaryKey = AllUsers.Add();
            //Set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //find the record
            AllUsers.ThisUsers.Find(PrimaryKey);
            //delete the record
            AllUsers.Delete();
            //now find the record
            Boolean Found = AllUsers.ThisUsers.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);


        }
        [TestMethod]
        public void ReportByUserNameMethodOK()
        {
            clsUsersCollection Allusers = new clsUsersCollection();
            //create an instance if the filtered data 
            clsUsersCollection FilteredUsers = new clsUsersCollection();
            //apply a blank string (should return all records);
            FilteredUsers.ReportByUserName("");
            Assert.AreEqual(Allusers.Count, FilteredUsers.Count);

        }
        [TestMethod]
        public void ReportByUserNameNoneFound()
        {
            //create an instance of the class we want to create 
            clsUsersCollection FilteredUsers = new clsUsersCollection();
            //apply a username that doesnt exist 
            FilteredUsers.ReportByUserName("xxxx");
            //test to see if that there are no records 
            Assert.AreEqual(0, FilteredUsers.Count);

        }
    }
}
