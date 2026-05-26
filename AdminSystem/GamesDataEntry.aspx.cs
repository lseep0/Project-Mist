using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

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
            clsGame AGame = new clsGame();
            AGame.Title = txtTitle.Text;
            AGame.Price = Convert.ToDecimal(txtPrice.Text);
            AGame.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
            AGame.IsEarlyAccess = chkIsEarlyAccess.Checked;

            Session["AGame"] = AGame;
            Response.Redirect("GamesViewer.aspx");
        }
    }
}