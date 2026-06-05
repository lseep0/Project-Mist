using System;
using System.Security.Cryptography;
using System.Text;
using ClassLibrary;

public partial class Register : System.Web.UI.Page
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

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            string hashedPassword = HashPassword(txtPassword.Text);

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@username", txtUsername.Text);
            DB.AddParameter("@email", txtEmail.Text);
            DB.AddParameter("@password_hash", hashedPassword);
            DB.AddParameter("@join_date", DateTime.Now.Date);
            DB.AddParameter("@Active", true);
            DB.AddParameter("@EmailVerified", false);

            DB.Execute("sproc_tblUsers_Insert");

            Response.Redirect("Login.aspx");
        }
        catch (Exception ex)
        {
            if (ex.Message.Contains("Violation of UNIQUE KEY constraint") || ex.Message.Contains("duplicate key"))
            {
                lblError.Text = "That username or email is already taken. Please choose another.";
            }
            else
            {
                lblError.Text = "An error occurred during registration. Please try again.";
            }
        }
    }
    protected void btnGoToLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}