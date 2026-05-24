using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace AdminSystem
{
    public partial class GamesViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsGame AGame = (clsGame)Session["AGame"];

            if (AGame != null)
            {
                Response.Write("Game Title Passed: <b>" + AGame.Title + "</b><br />");
                Response.Write("Game Price Passed: <b>£" + AGame.Price.ToString("0.00") + "</b><br />");
                Response.Write("Release Date Passed: <b>" + AGame.ReleaseDate.ToString("dd/MM/yyyy") + "</b><br />");
                Response.Write("Early Access Status: <b>" + AGame.IsEarlyAccess.ToString() + "</b><br />");
            }
        }
    }
}