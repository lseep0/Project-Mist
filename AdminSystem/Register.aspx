<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Register for Mist Store</h2>

                <label>Username:</label>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <br /><br />

                <label>Email:</label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <br /><br />

                <label>Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <br /><br />

                <asp:Button ID="btnRegister" runat="server" Text="Create Account" OnClick="btnRegister_Click" />
                <br /><br />

                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>

                <br /><br />
                <asp:Button ID="btnGoToLogin" runat="server" Text="Already have an account? Log In" OnClick="btnGoToLogin_Click" CausesValidation="false" />                
        </div>
    </form>
</body>
</html>
