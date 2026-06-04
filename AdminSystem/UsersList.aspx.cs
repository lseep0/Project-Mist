using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //display the record
            DisplayUsers();

        }
        
    }
    void DisplayUsers()
    {
        //create an instance of the users collection
        clsUsersCollection Users = new clsUsersCollection();
        //set the data source to the list of users in the collection
        lstUsersList.DataSource = Users.UsersList;
        //set the name of the primary key
        lstUsersList.DataValueField = "UserID";
        //set the data field to display
        lstUsersList.DataTextField = "UserName";
        //bind the data to the list
        lstUsersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session to indicate this is a new record
        Session["UserID"] = -1;
        //redirect to the data entry page
        Response.Redirect("UsersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 UserID;
        //if a record has been selected from the list
        if (lstUsersList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            UserID = Convert.ToInt32(lstUsersList.SelectedValue);
            //store the data in the session object
            Session["UserID"] = UserID;
            //redirect to the edit page
            Response.Redirect("UsersDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 UserID;
        if (lstUsersList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            UserID = Convert.ToInt32(lstUsersList.SelectedValue);
            Session["UserID"] = UserID;
            //redirect to the delete page
            Response.Redirect("UsersConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApplyFIlter_Click(object sender, EventArgs e)
    {
        //create an instance of the user object 
        clsUsersCollection AnUsers = new clsUsersCollection();
        //retrieve the value of the username from the presentation layer 
        AnUsers.ReportByUserName(txtFilter.Text);
        lstUsersList.DataSource = AnUsers.UsersList;
        lstUsersList.DataValueField = "UserID";
        lstUsersList.DataTextField = "UserName";
        lstUsersList.DataBind();
    }

    protected void btnCLearFilter_Click(object sender, EventArgs e)
    {
        clsUsersCollection AnUsers = new clsUsersCollection();
        //Set an empty 
        AnUsers.ReportByUserName("");
        //clear any existing filter to tiddy up the interface
        txtFilter.Text = "";
        lstUsersList.DataSource = AnUsers.UsersList;
        lstUsersList.DataValueField = "UserID";
        lstUsersList.DataTextField = "UserName";
        lstUsersList.DataBind();

    }
}
