using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of the clsUsers 
        clsUsers AnUsers = new clsUsers();
        //get the data from the session object
        AnUsers = (clsUsers)Session["AnUsers"];
        //display the user name for this entry
        Response.Write(AnUsers.UserName);

        //get the data from the session object
        AnUsers = (clsUsers)Session["AnUsers"];
        //display the user name for this entry
        Response.Write(AnUsers.Password);

        //get the data from the session object
        AnUsers = (clsUsers)Session["AnUsers"];
        //display the user name for this entry
        Response.Write(AnUsers.UserEmail);

        //get the data from the session object
        AnUsers.UserID = Convert.ToInt32(Session["UserID"]);
        //display the user name for this entry
        Response.Write(AnUsers.UserID);

        //get the data from the session object
        AnUsers.JoinedDate = Convert.ToDateTime(DateTime.Now);
        //display the user name for this entry
        Response.Write(AnUsers.JoinedDate);

        //capture active check box 
        AnUsers.Active = Convert.ToBoolean(Session["Active"]);
        Response.Write(AnUsers.Active);
        
        //capture the verfied email box 
        AnUsers.UserEmailVerified = Convert.ToBoolean(Session["Active"]);
        Response.Write(AnUsers.UserEmailVerified);

    }
}

