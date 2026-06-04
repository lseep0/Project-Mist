using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstUsers
    {
        //good test data
        //create some test data to pass to the method
        string UserName = "John Pork";
        string Password = "1234";
        string UserEmail = "johnpork@gmail.com";
        string JoinedDate = DateTime.Now.ToShortDateString();


        /****************INSTANCE OF THE CLASS TEST****************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //test to see that it exists
            Assert.IsNotNull(AnUsers);
        }

        /***************** PROPERTY OK TESTS*****************/
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
            Int32 TestData = 5;
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
        /***************** FIND METHOD TEST*****************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 UserID = 5;
            //invoke the method
            Found = AnUsers.Find(UserID);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }
        /***************** PROPRTY DATA TESTS*****************/
        [TestMethod]
        public void TestUserIDFound()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 5;
            //invoke the method
            Found = AnUsers.Find(UserID);
            //check the user id
            if (AnUsers.UserID != 5)
            {
                //test to fail
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestJoinedDateFound()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 5;
            //invoke the method
            Found = AnUsers.Find(UserID);
            //check the user id
            if (AnUsers.JoinedDate != Convert.ToDateTime("19/05/2022"))
            {
                //test to fail
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 5;
            //invoke the method
            Found = AnUsers.Find(UserID);
            //check the user id
            if (AnUsers.Active != true)
            {
                //test to fail
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserEmailVerifiedFound()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 5;
            //invoke the method
            Found = AnUsers.Find(UserID);
            //check the user id
            if (AnUsers.UserEmailVerified != true)
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserNameFound()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 5;
            //invoke the method
            Found = AnUsers.Find(UserID);
            //check the user id
            if (AnUsers.UserName != "John ")
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 5;
            //invoke the method
            Found = AnUsers.Find(UserID);
            //check the user id
            if (AnUsers.Password != "12345678")
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestUserEmailFound()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 5;
            //invoke the method
            Found = AnUsers.Find(UserID);
            //check the user id
            if (AnUsers.UserEmail != "JohnPork@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        /***************** VALIDATION METHOD TESTS*****************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnUsers.Valid(AnUsers.UserName, AnUsers.Password, AnUsers.UserEmail);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "";// this should trigger an error message
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be an error message)
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void UserNameMin()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "a";// this should be ok
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "aa";// this should be ok
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "aaaaaaaaaaaaaaaaaaaaa";// this should be ok
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMax()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "aaaaaaaaaaaaaaaaaaaaaa";// this should be ok
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMid()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //String variable to store any error message
            String Error = "aaaaaaaaaa";//this should be ok
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "aaaaaaaaaaaaaaaaaaaaaaa";// this should trigger an error message
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserName = "";
            UserName = UserName.PadRight(500, 'a');// this should trigger an error message
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JoinedDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be an error message)
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void JoinedDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JoinedDateMin()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JoinedDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JoinedDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string JoinedDate = TestDate.ToString();
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JoinedDateInvalidData()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            string JoinedDate = "this is not a date!";
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "aaaaaaaa";
            //create some test data to pass to the method
            string Password = "";// this should trigger an error message
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaa";// this should be ok (8 characters)
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaaa";// this should be ok (9 characters)
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaaaaaaaaaaaaaaa";// this should be ok (21 characters)
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaaaaaaaaaaaaaaaa";// this should be ok (22 characters)
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaaaaaaaaaaaaaaaaa";// this should trigger an error message (23 characters)
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsUsers AnUsers = new clsUsers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaaaaa";// this should be ok (11 characters)
            //invoke the method
            Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            //test to see that the result is OK (there should be no error message)
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsUsers anUsers = new clsUsers();
            // string variable to store any error message
            String Error = "";
            //this should pass 
            string UserEmail = "aaaaaaaaaaaaaaaaa";// this should pass (17 characters)
            //invoke the method
            Error = anUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserEmailMin()
        {
            //create an instance of the class we want to create
            clsUsers anUsers = new clsUsers();
            // string variable to store any error message
            String Error = "";
            //this should pass 
            string UserEmail = "aaaaaaaaaaaaaaaaaaa";// this should pass (18 characters)
            Error = anUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUsers anUsers = new clsUsers();
            // string variable to store any error message
            String Error = "";
            //this should pass 
            string UserEmail = "aaaaaaaaaaaaaaaaaaaa";// this should pass (19 characters)
            Error = anUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUsers anUsers = new clsUsers();
            // string variable to store any error message
            String Error = "";
            //this should pass 
            string UserEmail = "";
            UserEmail = UserEmail.PadRight(49, 'a');// this should pass (49 characters)
            Error = anUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserEmailMax()
        {
            //create an instance of the class we want to create
            clsUsers anUsers = new clsUsers();
            // string variable to store any error message
            String Error = "";
            //this should pass 
            string UserEmail = "";
            UserEmail = UserEmail.PadRight(50, 'a');// this should pass (50 characters)
            Error = anUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUsers anUsers = new clsUsers();
            // string variable to store any error message
            String Error = "";
            //this should fail 
            string UserEmail = "";
            UserEmail = UserEmail.PadRight(51, 'a');// this should fail (51 characters)
            Error = anUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserEmailMid()
        {
            //create an instance of the class we want to create
            clsUsers anUsers = new clsUsers();
            // string variable to store any error message
            String Error = "";
            //this should pass 
            string UserEmail = "";
            UserEmail = UserEmail.PadRight(25, 'a');// this should pass (26 characters)
            //invoke the method 
            Error = anUsers.Valid(UserName, Password, UserEmail, JoinedDate);
            Assert.AreEqual(Error, "");
        }
    }
}
  

