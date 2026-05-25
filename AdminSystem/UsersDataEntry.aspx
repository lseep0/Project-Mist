<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #lblUserID {
            height: 400px;
            width: 1143px;
        }
    </style>
</head>
<body id="lblUserID">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtUserID" runat="server" style="z-index: 1; left: 86px; top: 32px; position: absolute; height: 22px; width: 127px;"></asp:TextBox>
        <p>
            <asp:Label ID="UserID" runat="server" style="z-index: 1; left: 18px; top: 33px; position: absolute" Text="User ID"></asp:Label>
        </p>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 15px; top: 73px; position: absolute; margin-bottom: 0px" Text="Username " height="19px"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 85px; top: 71px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 15px; top: 109px; position: absolute" Text="Password" height="19px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 85px; top: 108px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 16px; top: 147px; position: absolute" Text="Email" height="19px"></asp:Label>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 85px; top: 144px; position: absolute" height="22px" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblJoinDate" runat="server" style="z-index: 1; left: 16px; top: 182px; position: absolute" Text="Join Date " height="19px"></asp:Label>
            <asp:CheckBox ID="chkVerified" runat="server" style="z-index: 1; left: 107px; top: 216px; position: absolute" Text="Email verified" />
        </p>
        <asp:TextBox ID="txtJoinDate" runat="server" style="z-index: 1; left: 85px; top: 178px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 28px; top: 216px; position: absolute" Text="Active" />
        <asp:Label ID="lblerror" runat="server" style="z-index: 1; left: 29px; top: 254px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 31px; top: 287px; position: absolute; width: 51px" Text="OK" />
        <p>
            <asp:Button ID="btncancel" runat="server" style="z-index: 1; left: 109px; top: 287px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
