using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminSystem
{
    public partial class GamesDataEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            clsGame AGame = new clsGame();
            Int32 GameId;
            Boolean Found = false;

            GameId = Convert.ToInt32(txtGameId.Text);
            Found = AGame.Find(GameId);

            if (Found == true)
            {
                txtTitle.Text = AGame.Title;
                txtPrice.Text = AGame.Price.ToString();
                txtReleaseDate.Text = AGame.ReleaseDate.ToString("yyyy-MM-dd");
                chkIsEarlyAccess.Checked = AGame.IsEarlyAccess;
            }
            else
            {
                txtTitle.Text = "Game Not Found!";
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            // Create an instance of clsGame
            clsGame AGame = new clsGame();

            // Store the error message
            string Error = "";

            // Call the Valid method and capture any errors
            Error = AGame.Valid(txtTitle.Text, txtPrice.Text, txtReleaseDate.Text);

            if (Error == "")
            {
                // If there are no errors, proceed with saving
                AGame.Title = txtTitle.Text;
                AGame.Price = Convert.ToDecimal(txtPrice.Text);
                AGame.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
                AGame.IsEarlyAccess = chkIsEarlyAccess.Checked;

                Session["AGame"] = AGame;
                Response.Redirect("GamesViewer.aspx");
            }
            else
            {
                // If there is an error, display it in a label
                lblError.Text = Error;
            }
        }
    }
}