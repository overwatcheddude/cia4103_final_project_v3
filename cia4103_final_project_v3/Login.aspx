<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Email: 
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFVemail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please enter your email." Display="None"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="REVemail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please enter a valid email." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="None"></asp:RegularExpressionValidator>
            <br />
            Password: 
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFVpassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter your password." Display="None"></asp:RequiredFieldValidator>
            <br />
            <asp:CheckBox ID="cbRememberEmail" runat="server" Text="Remember Email?" />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>
    </form>
</body>
</html>