using System;
using ClassLibrary;

namespace AdminSystem
{
    public partial class GamesDataEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Convert.ToInt32(Session["GameId"]) != 0)
                {
                    DisplayGame();
                }
            }
        }

        void DisplayGame()
        {
            Int32 GameId = Convert.ToInt32(Session["GameId"]);
            clsGameCollection GameBook = new clsGameCollection();

            if (GameBook.ThisGame.Find(GameId))
            {
                txtGameId.Text = GameBook.ThisGame.GameId.ToString();
                txtTitle.Text = GameBook.ThisGame.Title;
                txtPrice.Text = GameBook.ThisGame.Price.ToString();
                txtReleaseDate.Text = GameBook.ThisGame.ReleaseDate.ToString("yyyy-MM-dd");
                chkIsEarlyAccess.Checked = GameBook.ThisGame.IsEarlyAccess;
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            clsGame AGame = new clsGame();
            Int32 GameId = Convert.ToInt32(txtGameId.Text);

            if (AGame.Find(GameId))
            {
                txtTitle.Text = AGame.Title;
                txtPrice.Text = AGame.Price.ToString();
                txtReleaseDate.Text = AGame.ReleaseDate.ToString("yyyy-MM-dd");
                chkIsEarlyAccess.Checked = AGame.IsEarlyAccess;
                lblError.Text = ""; 
            }
            else
            {
                lblError.Text = "Game ID not found.";
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            clsGame AGame = new clsGame();
            string Error = AGame.Valid(txtTitle.Text, txtPrice.Text, txtReleaseDate.Text);

            if (Error == "")
            {
                AGame.GameId = Convert.ToInt32(txtGameId.Text == "" ? "0" : txtGameId.Text);
                AGame.Title = txtTitle.Text;
                AGame.Price = Convert.ToDecimal(txtPrice.Text);
                AGame.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
                AGame.IsEarlyAccess = chkIsEarlyAccess.Checked;

                clsGameCollection GameList = new clsGameCollection();

                if (AGame.GameId == 0) 
                {
                    GameList.ThisGame = AGame;
                    GameList.Add();
                }
                else 
                {
                    GameList.ThisGame.Find(AGame.GameId);
                    GameList.ThisGame = AGame;
                    GameList.Update();
                }
                Response.Redirect("GamesList.aspx");
            }
            else
            {
                lblError.Text = Error;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamesList.aspx");
        }
    }
}