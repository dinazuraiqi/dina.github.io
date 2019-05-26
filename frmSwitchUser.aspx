<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSwitchUser.aspx.cs" Inherits="frmSwitchUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="text-align: center">
            <br />
            </p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtUserName" runat="server" CausesValidation="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server" CausesValidation="True" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="btnLoggin" runat="server" Text="Loggin" OnClick="btnLoggin_Click" style="margin-left: 0px" Width="67px" />
        &nbsp;
            </p>
    </form>
</body>
</html>
