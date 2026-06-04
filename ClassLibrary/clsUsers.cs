using System;
using System.IO;
using System.Runtime.Remoting.Messaging;

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
        /***********FIND METHOD************/
        public bool Find(int userID)
        {
            //create an instance of the data connection class
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the user ID to search for
            DB.AddParameter("@userId", userID);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FilterByUserID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["userId"]);
                mJoinedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["join_date"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["password_hash"]);
                mUserEmail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                mUserEmailVerified = Convert.ToBoolean(DB.DataTable.Rows[0]["EmailVerified"]);
                //return that everything worked OK
                return true;
            }
            else 
            {
                return false; 
            }
        }

        public string Valid(string userName, string password, string userEmail, string joinedDate)
        {
            //create a string variable to store the error
            String Error = "";  
            //create a temporary variable to store the data value
            DateTime DateTemp;
            //if the user name is blank
            if (userName.Length == 0)
            {
                //record the error
                Error = Error + "The user name may not be blank : ";
            }
            if (userName.Length > 22)
            {
                Error = Error + "The user name must be less than 22 characters : ";
            }
            //create an instance of the datetime to compare with date temp
            //in the if statements 
            DateTime Datecomp = DateTime.Now.Date;

            try
            {
                //copy the joined date value to the date temp variable
                DateTemp = Convert.ToDateTime(joinedDate);
                if (DateTemp < Datecomp)//compare Joined date with the current date
                {
                    //record the error 
                    Error = Error + "The joined date cannot be in the past : ";
                }
                if (DateTemp > Datecomp)
                {
                    //record the error 
                    Error = Error + "The joined date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The joined date is not a valid date : ";
            }
            if (password.Length == 0)
            {
                //record the error
                Error = Error + "The password may not be blank : ";
            }
            if(password.Length > 22)
            {
                Error = Error + "The password must be less than 22 characters : ";
            }
            if (userEmail.Length == 0)
            {
                //record the error
                Error = Error + "The user email may not be blank : ";
            }
            if(userEmail.Length > 50)
            {
                Error = Error + "The user email must be less than 50 characters : ";
            }
            return Error;


        }

        public string Valid(string userName, string password, string userEmail)
        {
            return "";
        }
    } 
}