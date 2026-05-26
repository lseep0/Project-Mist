using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminSystem
{
    public partial class GamesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If this is the first time the page is displayed
            if (IsPostBack == false)
            {
                // Update the list box
                DisplayGames();
            }
        }

        void DisplayGames()
        {
            // Create an instance of the Game collection
            clsGameCollection AllGames = new clsGameCollection();

            // Set the data source to list of games in the collection
            lstGameList.DataSource = AllGames.GameList;

            // Set the name of the primary key
            lstGameList.DataValueField = "GameId";

            // Set the data field to display (e.g., the title)
            lstGameList.DataTextField = "Title";

            // Bind the data to the list
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
            // Redirect to the data entry page
            Response.Redirect("GamesDataEntry.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstGameList.SelectedIndex != -1)
            {
                // Store the ID in the session
                Session["GameId"] = lstGameList.SelectedValue;
                // Redirect to the entry page
                Response.Redirect("GamesDataEntry.aspx");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure a record is selected
            if (lstGameList.SelectedIndex != -1)
            {
                // Get the ID of the selected record
                Int32 GameId = Convert.ToInt32(lstGameList.SelectedValue);

                // Create collection and assign ID to be deleted
                clsGameCollection AllGames = new clsGameCollection();
                AllGames.ThisGame.GameId = GameId;
                AllGames.Delete();

                // Refresh the list
                DisplayGames();
            }
        }

    }
}