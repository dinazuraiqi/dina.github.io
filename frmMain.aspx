<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        &nbsp;
        <asp:Button ID="btnRegisteration" runat="server" OnClick="btnRegisteration_Click" Text="Registeration" Width="249px" />
        <br />
&nbsp;
        <br />
&nbsp;
        <asp:Button ID="btnBloodTypes" runat="server" OnClick="btnBloodTypes_Click" Text="Blood Types" Width="249px" />
        <br />
        <br />
&nbsp;
        <asp:Button ID="btnRequestsList" runat="server" style="margin-left: 0px" Text="Requests List" Width="249px" OnClick="btnRequestsList_Click" />
        <br />
        <br />
&nbsp;
        <asp:Button ID="btnSwitchUser" runat="server" OnClick="btnSwitchUser_Click" Text="Switch User" Width="249px" />
        <br />
        <br />
    </form>
</body>
</html>
