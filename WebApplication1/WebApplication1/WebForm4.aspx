<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>
<%@ Register src="AgeValidationUC.ascx" tagname="AgeValidationUC" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #00FFFF">
            <table style="width: auto;">
            <tr>
                <td>NAME: </td>
                <td><asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></td>
                <td style="background-color: #C0C0C0"> *</td>
                
            </tr>
            <tr>
                <td>ROLL NO:</td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                <td> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>ADDRESS:</td>
                <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                <td> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox3"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>EMAIL:</td>
                <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="TextBox4"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>TELEP:</td>
                <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="TextBox5"></asp:RequiredFieldValidator></td>
            </tr>
        </table> <br />
        <asp:Button ID="Button1" runat="server" Text="SHOW" OnClick="Button1_Click" BackColor="#FF3300" />
            <br />
            <br />
            <br />
            <br />
            <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
            <br />
            <br />
            <uc2:AgeValidationUC ID="AgeValidationUC1" runat="server" />
            <br />
        </div>
    </form>
</body>
</html>
