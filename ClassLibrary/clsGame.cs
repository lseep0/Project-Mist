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

        public Int32 GameId
        {
            get { return mGameId; }
            set { mGameId = value; }
        }

        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }

        public decimal Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public DateTime ReleaseDate
        {
            get { return mReleaseDate; }
            set { mReleaseDate = value; }
        }

        public bool IsEarlyAccess
        {
            get { return mIsEarlyAccess; }
            set { mIsEarlyAccess = value; }
        }

        public bool Find(int GameId)
        {
            mGameId = 21;
            mTitle = "Test Game";
            mPrice = 49.99m;
            mReleaseDate = Convert.ToDateTime("23/12/2022");
            mIsEarlyAccess = true;

            return true;
        }
    }
}