using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 UserID;

    protected void Page_Load(object sender, EventArgs e)
    {
        UserID = Convert.ToInt32(Session["UserID"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsUsersCollection Users = new clsUsersCollection();
        //find the record to delete 
        Users.ThisUsers.Find(UserID);
        //delete the record
        Users.Delete();
        Response.Redirect("UsersList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsersList.aspx");
    }
}