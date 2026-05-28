using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace AdminSystem
{
    public partial class GamesConfirmDelete : System.Web.UI.Page
    {
        Int32 GameId;

        protected void Page_Load(object sender, EventArgs e)
        {
            GameId = Convert.ToInt32(Session["GameId"]);
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            clsGameCollection GameBook = new clsGameCollection();

            GameBook.ThisGame.Find(GameId);

            GameBook.Delete();

            Response.Redirect("GamesList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamesList.aspx");
        }
    }
}