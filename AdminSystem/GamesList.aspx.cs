using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminSystem
{
    public partial class GamesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userID"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (IsPostBack == false)
            {
                DisplayGames();
            }
        }

        void DisplayGames()
        {
            clsGameCollection AllGames = new clsGameCollection();

            lstGameList.DataSource = AllGames.GameList;

            lstGameList.DataValueField = "GameId";

            lstGameList.DataTextField = "Title";

            lstGameList.DataBind();
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            clsGameCollection AllGames = new clsGameCollection();
            AllGames.ReportByTitle(txtTitle.Text);
            lstGameList.DataSource = AllGames.GameList;
            lstGameList.DataValueField = "GameId";
            lstGameList.DataTextField = "Title";
            lstGameList.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamesDataEntry.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstGameList.SelectedIndex != -1)
            {
                Session["GameId"] = lstGameList.SelectedValue;
                Response.Redirect("GamesDataEntry.aspx");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstGameList.SelectedIndex != -1)
            {
                Session["GameId"] = lstGameList.SelectedValue;

                Response.Redirect("GamesConfirmDelete.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete from the list.";
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Redirect("Login.aspx");
        }

    }
}