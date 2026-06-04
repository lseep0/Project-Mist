<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 56px; top: 125px; position: absolute; width: 78px" Text="Yes" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; top: 125px; position: absolute; width: 83px; left: 170px" Text="No" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 35px; top: 84px; position: absolute" Text="Are you sure you want to delete this record ?"></asp:Label>
    </form>
</body>
</html>
