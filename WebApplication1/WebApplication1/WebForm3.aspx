<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: 'Arial Black'; background-color: #FFFF00">
    
        <asp:Label ID="Label1" runat="server" Text="FirstName:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" BackColor="Aqua"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="LastName:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" BackColor="#33CCFF" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Load" />
    
    </div>
    </form>
</body>
</html>
