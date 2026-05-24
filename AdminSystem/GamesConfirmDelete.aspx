<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamesConfirmDelete.aspx.cs" Inherits="AdminSystem.GamesConfirmDelete" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Are you sure you want to delete this game?</h2>
            <br />
            <asp:Button ID="btnYes" runat="server" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </div>
    </form>
</body>
</html>