using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page

{
    Int32 UserID;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        UserID = Convert.ToInt32(Session["UserID"]);
        if (IsPostBack == false)
        {
            if (UserID != -1)
            {
                //display the record
                DisplayUser();
            }
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        
        //create a new instance of clsUsers
        clsUsers AnUsers = new clsUsers();
        //capture the user name
        
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        string UserEmail = txtEmail.Text;
        string JoinedDate = txtJoinDate.Text;
        string checkActive = chkActive.Checked.ToString();
        string checkVerified = chkVerified.Checked.ToString();
        string Error = "";
        Error = AnUsers.Valid(UserName, Password, UserEmail, JoinedDate);
        if (Error == "")
        {
            AnUsers.UserID = UserID;
            //capture the user name
            AnUsers.UserName = UserName;
            //capture the password
            AnUsers.Password = Password;
            //capture the email
            AnUsers.UserEmail = UserEmail;
            //capture the join date
            AnUsers.JoinedDate = Convert.ToDateTime(JoinedDate);
            //capture the active status
            AnUsers.Active = chkActive.Checked;
            //capture the email verified status
            AnUsers.UserEmailVerified = chkVerified.Checked;
            clsUsersCollection UsersList = new clsUsersCollection();

            if (UserID == -1)
            {
                //set the ThisUsers property
                UsersList.ThisUsers = AnUsers;
                //add the new record
                UsersList.Add();
            }
            else
            {
                //find the record to update
                UsersList.ThisUsers.Find(UserID);
                //set the ThisUsers property
                UsersList.ThisUsers = AnUsers;
                //update the record
                UsersList.Update();
            }
            UsersList.ThisUsers = AnUsers;
            UsersList.Add();
            //Navigate to the viewer page
            Response.Redirect("UsersViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        } 
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsUsers AnUsers = new clsUsers();
        //create a variable to store the result of the find operation
        Int32 UserID;
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
    void DisplayUser()
    {
        //create an instance of the class
        clsUsersCollection Users = new clsUsersCollection();
        //find the record to update 
        Users.ThisUsers.Find(UserID);
        //display the data for this record
        txtUserID.Text = Users.ThisUsers.UserID.ToString();
        txtUserName.Text = Users.ThisUsers.UserName.ToString();
        txtPassword.Text = Users.ThisUsers.Password.ToString();
        txtEmail.Text = Users.ThisUsers.UserEmail.ToString();
        txtJoinDate.Text = Users.ThisUsers.JoinedDate.ToString();
        chkActive.Checked = Users.ThisUsers.Active;
        chkVerified.Checked = Users.ThisUsers.UserEmailVerified;

    }
}