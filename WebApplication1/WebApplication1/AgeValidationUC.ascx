<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AgeValidationUC.ascx.cs" Inherits="WebApplication1.AgeValidationUC" %>
AGE : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter a valid age between 20  - 50" ControlToValidate="TextBox1" ForeColor="Red" MaximumValue="50" MinimumValue="20" Type="Integer"></asp:RangeValidator>
<br />
<asp:Button ID="Button1" runat="server" Text="Button" />