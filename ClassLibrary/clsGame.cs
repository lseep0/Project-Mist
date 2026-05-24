using System;

namespace ClassLibrary
{
    public class clsGame
    {
        // 1. Private data members (Backing fields hidden from outside classes)
        private Int32 mGameId;
        private string mTitle;
        private decimal mPrice;
        private DateTime mReleaseDate;
        private bool mIsEarlyAccess;

        // 2. Public Property Procedures

        public Int32 GameId
        {
            get
            {
                // This code sends data OUT of the property
                return mGameId;
            }
            set
            {
                // This code allows data INTO the property
                mGameId = value;
            }
        }

        public string Title
        {
            get
            {
                return mTitle;
            }
            set
            {
                mTitle = value;
            }
        }

        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return mReleaseDate;
            }
            set
            {
                mReleaseDate = value;
            }
        }

        public bool IsEarlyAccess
        {
            get
            {
                return mIsEarlyAccess;
            }
            set
            {
                mIsEarlyAccess = value;
            }
        }
    }
}