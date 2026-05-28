<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamesDataEntry.aspx.cs" Inherits="AdminSystem.GamesDataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Game Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Game Details</h1>
            
            <asp:TextBox ID="txtGameId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            <br /><br />

            Title: <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br />
            Price: <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />
            Release Date: <asp:TextBox ID="txtReleaseDate" runat="server" TextMode="Date"></asp:TextBox><br />
            Early Access: <asp:CheckBox ID="chkIsEarlyAccess" runat="server" /><br />
            
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            
            <br /><br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>a