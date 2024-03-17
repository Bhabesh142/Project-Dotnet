<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="FIRST NAME:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br /> <br />
&nbsp;<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /> <br /> <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>


</asp:Content>
