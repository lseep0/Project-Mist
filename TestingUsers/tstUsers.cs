using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstUsers
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //test to see that it exists
            Assert.IsNotNull(AnUsers);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnUsers.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUsers.Active, TestData);
        }
        [TestMethod]
        public void JoinedDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnUsers.JoinedDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUsers.JoinedDate, TestData);

        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUsers.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUsers.UserID, TestData);

        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            string TestData = "John Pork";
            //assign the data to the property
            AnUsers.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUsers.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //create some test data to assign to the property
            string TestData = "1234";
            //assign the data to the property
            AnUsers.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUsers.Password, TestData);

        }
        [TestMethod]
        public void UserEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //create some test data to assign to the property
            string TestData = "JohnPork@gmail.com";
            //assign the data to the property
            AnUsers.UserEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUsers.UserEmail, TestData);
        }
        [TestMethod]
        public void UserEmailVerifiedPropertyOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnUsers.UserEmailVerified = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUsers.UserEmailVerified, TestData);

        }

    }
}
