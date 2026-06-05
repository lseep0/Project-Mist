<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Log in to Mist Store</h2>

            <label>Username:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br /><br />

            <label>Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="btnLogin_Click" />
            <br /><br />

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br /><br />

            <p>Don't have an account? <a href="Register.aspx">Register here</a></p>
        </div>
    </form>
</body>
</html>
