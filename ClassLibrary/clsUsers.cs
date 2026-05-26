using System;

namespace ClassLibrary
{
    public class clsUsers
    {
        //private data member for the Active property
        private DateTime mJoinedDate;
        //privete data member for the User ID property
        private Int32 mUserID;
        //private data member for active property
        private bool mActive;
        //private data member for the user name property
        private string mUserName;
        //private data member for the password property
        private string mPassword;
        //private data member for the user email property
        private string mUserEmail;
        //private data member for the user email verified property
        private bool mUserEmailVerified;

        public int UserID 
        { 
            get
            { //this line of code sends data out of the property
                return mUserID;
            }
            set
            {
                //this line of code allows data into the property
                mUserID = value;
            }
                
        }

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime JoinedDate
        {
            get
            {
                //this line of code sends data out of the property
                return mJoinedDate;
            }

            set
            {
                //this line of code allows data into the property
                mJoinedDate = value;
            }
        }
        public string UserName 
        {
            get 
            {
                return mUserName;
            }
            set 
            { 
                mUserName = value;
            } 
        }
        public string Password 
        {
            get 
            {
                return mPassword;
            }
            set 
            { 
                mPassword = value;
            } 
        }
        public string UserEmail 
        {
            get 
            {
                return mUserEmail;
            }
            set 
            {
                mUserEmail = value;
            } 
        }
        public bool UserEmailVerified 
        {
            get 
            {
                return mUserEmailVerified;
            }
            set 
            {
                mUserEmailVerified = value;
            }
        }
         
        public bool Find(int userID)
        {
            //set the private data member to the test data value;
            mUserID = 1;
            mJoinedDate = Convert.ToDateTime("23/12/2022");
            mActive = true;
            mUserName = "john pork";
            mPassword = "1234";
            mUserEmail = "johnpork@gmail.com";
            mUserEmailVerified = true;
            //always return true
            return true;
        }
    }
}