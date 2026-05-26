using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsGameCollection
    {
        // Private data members
        List<clsGame> mGameList = new List<clsGame>();
        clsGame mThisGame = new clsGame();

        // Constructor
        public clsGameCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblGame_SelectAll");
            PopulateArray(DB);
        }

        // Public properties
        public List<clsGame> GameList
        {
            get { return mGameList; }
            set { mGameList = value; }
        }

        public int Count
        {
            get { return mGameList.Count; }
        }

        public clsGame ThisGame
        {
            get { return mThisGame; }
            set { mThisGame = value; }
        }

        // CRUD Methods
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Title", mThisGame.Title);
            DB.AddParameter("@Price", mThisGame.Price);
            DB.AddParameter("@ReleaseDate", mThisGame.ReleaseDate);
            DB.AddParameter("@IsEarlyAccess", mThisGame.IsEarlyAccess);
            return DB.Execute("sproc_tblGame_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@GameId", mThisGame.GameId);
            DB.AddParameter("@Title", mThisGame.Title);
            DB.AddParameter("@Price", mThisGame.Price);
            DB.AddParameter("@ReleaseDate", mThisGame.ReleaseDate);
            DB.AddParameter("@IsEarlyAccess", mThisGame.IsEarlyAccess);
            DB.Execute("sproc_tblGame_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@GameId", mThisGame.GameId);
            DB.Execute("sproc_tblGame_Delete");
        }

        public void ReportByTitle(string Title)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Title", Title);
            DB.Execute("sproc_tblGame_FilterByTitle");
            PopulateArray(DB);
        }

        // Helper engine
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;
            mGameList = new List<clsGame>();

            while (Index < RecordCount)
            {
                clsGame AGame = new clsGame();
                AGame.GameId = Convert.ToInt32(DB.DataTable.Rows[Index]["GameId"]);
                AGame.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AGame.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AGame.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                AGame.IsEarlyAccess = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsEarlyAccess"]);
                mGameList.Add(AGame);
                Index++;
            }
        }
    }
}
