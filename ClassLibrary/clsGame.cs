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

        public string Valid(string title, string price, string releaseDate)
        {
            string Error = "";
            DateTime DateTemp;

            if (title == null)
            {
                title = "";
            }

            // --- Title Validation ---
            if (title.Length == 0) { Error = Error + "The title cannot be blank. "; }
            if (title.Length > 50) { Error = Error + "The title must be less than 50 chars. "; }
            
            if (title.Length == 0)
            {
                Error = Error + "The title may not be blank : ";
            }


            // --- Price Validation ---
            try
            {
                decimal PriceTemp = Convert.ToDecimal(price);
                if (PriceTemp < 0) { Error = Error + "Price cannot be negative. "; }
                if (PriceTemp > 1000) { Error = Error + "Price is too high. "; }
            }
            catch { Error = Error + "The price was not a valid number. "; }

            // --- Release Date Validation ---
            try
            {
                DateTemp = Convert.ToDateTime(releaseDate);
                if (DateTemp < Convert.ToDateTime("01/01/1950")) { Error = Error + "Date is too far in the past. "; }
                if (DateTemp > DateTime.Now.Date) { Error = Error + "Date cannot be in the future. "; }
            }
            catch { Error = Error + "The date was not a valid date. "; }

            return Error;
        }
    }
}