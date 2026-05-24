<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamesDataEntry.aspx.cs" Inherits="AdminSystem.GamesDataEntry" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Game Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Game Data Entry Screen</h2>
            
            <asp:Label ID="lblTitle" runat="server" Text="Game Title: "></asp:Label>
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblPrice" runat="server" Text="Price (£): "></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblReleaseDate" runat="server" Text="Release Date: "></asp:Label>
            <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
            <br /><br />

            <asp:CheckBox ID="chkIsEarlyAccess" runat="server" Text=" Is Early Access" />
            <br /><br />

            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>