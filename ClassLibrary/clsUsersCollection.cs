using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
namespace ClassLibrary
{
    public class clsUsersCollection
    {

        List<clsUsers> mUsersList = new List<clsUsers>();

        //private data member for the ThisUsers property
        clsUsers mThisUsers = new clsUsers();
        public List<clsUsers> UsersList
        {
            get
            {
                //return the private data
                return mUsersList;
            }
            set
            {
                //set the private data
                mUsersList = value;
            }
        }

        public int Count
        {
            get
            {
                return mUsersList.Count;
            }
            set
            {

            }
        }
        public clsUsers ThisUsers
        {
            get
            {
                //return the private data
                return mThisUsers;
            }
            set
            {
                //set the private data
                mThisUsers = value;
            }
        }

        //constructor for the class
        public clsUsersCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //execute stored procedure 
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblUsers_SelectAll");
            //populate the array 
            PopulateArray(DB);
            //get the count of records
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //create a blank user
                clsUsers AUser = new clsUsers();
                //read in the fields from the current record
                AUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["userId"]);
                AUser.UserName = Convert.ToString(DB.DataTable.Rows[Index]["username"]);
                AUser.Password = Convert.ToString(DB.DataTable.Rows[Index]["password_hash"]);
                AUser.UserEmail = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                AUser.JoinedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["join_date"]);
                AUser.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AUser.UserEmailVerified = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmailVerified"]);
                //add the record to the private data member
                mUsersList.Add(AUser);
                //point at the next record
                Index++;

            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisUsers
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@username", mThisUsers.UserName);
            DB.AddParameter("@password_hash", mThisUsers.Password);
            DB.AddParameter("@email", mThisUsers.UserEmail);
            DB.AddParameter("@join_date", mThisUsers.JoinedDate);
            DB.AddParameter("@Active", mThisUsers.Active);
            DB.AddParameter("@EmailVerified", mThisUsers.UserEmailVerified);

            //execcute the query returning the primary key value
            return DB.Execute("sproc_tblUsers_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisUsers
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramemeters for the  new stored procedure
            DB.AddParameter("@userId", mThisUsers.UserID);
            DB.AddParameter("@username", mThisUsers.UserName);
            DB.AddParameter("@password_hash", mThisUsers.Password);
            DB.AddParameter("@email", mThisUsers.UserEmail);
            DB.AddParameter("@join_date", mThisUsers.JoinedDate);
            DB.AddParameter("@Active", mThisUsers.Active);
            DB.AddParameter("@EmailVerified", mThisUsers.UserEmailVerified);
            //Execute the stored procedure
            DB.Execute("sproc_tblUsers_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by ThisUsers
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@userId", mThisUsers.UserID);
            //DB.execute the stored procedure
            DB.Execute("sproc_tblUsers_Delete");

        }

        public void ReportByUserName(string UserName)
        {
            //fillers the records based on a full or partial username
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the username parameter to the database 
            DB.AddParameter("@username", UserName);
            //execute the stored procdure 
            DB.Execute("sproc_tblUsers_FilterByUserName");
            //populate the array list with the data table
            PopulateArray(DB);

        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates  the array list based on the data in the table in the parameter DB
            //variable for the index 
            Int32 Index = 0;
            //get the count of the records
            Int32 RecordCount;
            RecordCount = DB.Count;
            //clear the private array list 
            mUsersList = new List<clsUsers>();
            //while there are records to process 
            while (Index < RecordCount) 
            { 
                clsUsers AnUsers = new clsUsers();
                //read in the fields from the current record
                AnUsers.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["userId"]);
                AnUsers.UserName = Convert.ToString(DB.DataTable.Rows[Index]["username"]);
                AnUsers.Password = Convert.ToString(DB.DataTable.Rows[Index]["password_hash"]);
                AnUsers.UserEmail = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                AnUsers.JoinedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["join_date"]);
                AnUsers.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnUsers.UserEmailVerified = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmailVerified"]);
                //add the record to the private data memeber 
                mUsersList.Add(AnUsers);
                //point at the indez record 
                Index++;

            }
        }
    }
}


    
