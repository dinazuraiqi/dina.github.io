<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body >
   
    <form id="form1" runat="server">
        <div class="auto-style1" style="background-image: url('Blood Channel.PNG'); background-repeat:no-repeat;background-attachment:fixed;background-position: 50% top ; height: 332px;">
            <br />
            <br />
            <br />
            <br />
            <br />
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
            <asp:Button ID="btnRegister" runat="server" CausesValidation="False" OnClick="btnRegister_Click" Text="Register" />
        </div>
    </form>
</body>
</html>
