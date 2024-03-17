<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm12.aspx.cs" Inherits="WebApplication1.WebForm12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label3"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Select your Brand Preferences:"></asp:Label>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="apple" runat="server" Text="apple" />
        <br />
        <br />
        <asp:CheckBox ID="dell" runat="server" Text="dell" />
        <br />
        <br />
        <asp:CheckBox ID="lenovo" runat="server" Text="lenovo" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label2"></asp:Label>
    </form>
</body>
</html>
