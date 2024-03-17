<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <table style="background-color: #C0C0C0; margin-bottom: 16px;">
                <tr>
                    <td colspan="2" style="width:800px; height:80px; text-align:center; background-color:cornflowerblue;">
                        <h1> Master page header </h1>
                    </td>
                    
                </tr>
                <tr>
                    <td style="height:500px; background-color:aqua; width:150px; ">
                        <h3>MENU</h3>
                    </td>
                    <td style="height:500px; background-color:darkcyan; width:650px;">
                        <h4> Content Page will be shownn here. </h4>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="background-color:aliceblue; text-align:center;">
                        <h2>Master page footer</h2>
                    </td>
                    
                </tr>
            </table>
        </div>
    </form>
</asp:Content>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
</body>
</html>
