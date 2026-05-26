<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamesList.aspx.cs" Inherits="AdminSystem.GamesList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Game List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstGameList" runat="server" Height="250px" Width="300px"></asp:ListBox>
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>