using System;
using System.Security.Cryptography;
using System.Text;
using ClassLibrary;

public partial class Login : System.Web.UI.Page
{
    private string HashPassword(string plainText)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@username", txtUsername.Text);
        DB.Execute("sproc_tblUsers_GetByUsername");

        if (DB.Count == 1)
        {
            string savedHash = Convert.ToString(DB.DataTable.Rows[0]["password_hash"]);

            string inputHash = HashPassword(txtPassword.Text);

            if (savedHash == inputHash)
            {
                Session["userID"] = Convert.ToInt32(DB.DataTable.Rows[0]["userID"]);
                Session["username"] = txtUsername.Text;
                Response.Redirect("GamesList.aspx");
            }
            else
            {
                lblError.Text = "DB Length: " + savedHash.Length + " | Input Length: " + inputHash.Length + "<br/>" +
                                "DB Hash: " + savedHash + "<br/>" +
                                "Input: " + inputHash;
            }
        }
        else
        {
            lblError.Text = "Username not found.";
        }
    }
    protected void btnGoToRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}