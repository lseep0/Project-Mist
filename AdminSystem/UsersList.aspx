<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 711px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstUsersList" runat="server" style="z-index: 1; left: 15px; top: 49px; position: absolute; height: 374px; width: 311px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 429px; position: absolute; height: 26px" Text="Add" width="55px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 86px; top: 429px; position: absolute" Text="Edit" height="26px" width="55px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 156px; top: 429px; position: absolute" Text="Delete" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnApplyFIlter" runat="server" OnClick="btnApplyFIlter_Click" style="z-index: 1; left: 16px; top: 558px; position: absolute; width: 83px" Text="Apply Filter" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 15px; top: 501px; position: absolute; height: 24px" Text="Enter a Username"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCLearFilter" runat="server" height="26px" OnClick="btnCLearFilter_Click" style="z-index: 1; left: 130px; top: 558px; position: absolute; width: 83px" Text="CLear FIlter" />
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 38px; top: 614px; position: absolute"></asp:Label>
        </p>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 149px; top: 502px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
