<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #00FF00">
    
        <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="#FF3300" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator">Please enter your name.</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Password:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" BackColor="#FF3300" ControlToCompare="TextBox3" ControlToValidate="TextBox2" ErrorMessage="CompareValidator">Enter your Password.</asp:CompareValidator>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter Re-Password:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" BackColor="#FF3300" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="CompareValidator">Enter your Password again.</asp:CompareValidator>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" BackColor="#FF3300" ControlToValidate="TextBox4" ErrorMessage="RangeValidator" MaximumValue="50" MinimumValue="20">Enter your age between 20-50</asp:RangeValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" />
    
    </div>
    </form>
</body>
</html>
