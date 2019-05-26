<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmAddRequest.aspx.cs" Inherits="frmAddRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <br />
            <br />
            <br />
            <br />
            UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUserNmae" runat="server" CausesValidation="True" Width="258px"></asp:TextBox>
            <br />
            <br />
            Description Details&nbsp;&nbsp; <asp:TextBox ID="txtDescriptionDetails" runat="server" CausesValidation="True" TextMode="MultiLine" Width="258px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" Width="72px" />
        </div>
    </form>
</body>
</html>
