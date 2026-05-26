using System;

namespace ClassLibrary
{
    public class clsGame
    {
        private Int32 mGameId;
        private string mTitle;
        private decimal mPrice;
        private DateTime mReleaseDate;
        private bool mIsEarlyAccess;

        public Int32 GameId { get { return mGameId; } set { mGameId = value; } }
        public string Title { get { return mTitle; } set { mTitle = value; } }
        public decimal Price { get { return mPrice; } set { mPrice = value; } }
        public DateTime ReleaseDate { get { return mReleaseDate; } set { mReleaseDate = value; } }
        public bool IsEarlyAccess { get { return mIsEarlyAccess; } set { mIsEarlyAccess = value; } }

        public bool Find(int GameId)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@GameId", GameId);
            DB.Execute("sproc_tblGame_FilterByGameId");

            if (DB.Count == 1)
            {
                mGameId = Convert.ToInt32(DB.DataTable.Rows[0]["GameId"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mIsEarlyAccess = Convert.ToBoolean(DB.DataTable.Rows[0]["IsEarlyAccess"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}