using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUsers
        clsUsers AnUsers = new clsUsers();
        //capture the user name
        AnUsers.UserName = txtUserName.Text;
        Session["AnUsers"] = AnUsers;
        //Navigate to the viewer page
        Response.Redirect("UsersViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsUsers AnUsers = new clsUsers();
        //create a variable to store the result of the find operation
        int UserID;
        //fet the primary key value entered by the user
        Boolean Found = false;
        //find the primary key value entered 
        UserID = Convert.ToInt32(txtUserID.Text);
        //find the record
        Found = AnUsers.Find(UserID);
        if (Found == true)
        {
            //display the values of the properties in the form
            txtUserName.Text = AnUsers.UserName;
            txtPassword.Text = AnUsers.Password;   
            txtEmail.Text = AnUsers.UserEmail;
            txtJoinDate.Text = AnUsers.JoinedDate.ToString();
            chkActive.Checked = AnUsers.Active;
            chkVerified.Checked = AnUsers.UserEmailVerified;
        }
    }
}