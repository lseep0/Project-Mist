using System;

namespace ClassLibrary
{
    public class clsUsers
    {
        //privete data member for the User ID property

        private Int32 mUserID;
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

        public bool Active { get; set; }
        public DateTime JoinedDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public bool UserEmailVerified { get; set; }

        public bool Find(int userID)
        {
            //set the private data member to the test data value;
            mUserID = 1;
            //always return true
            return true;
        }
    }
}