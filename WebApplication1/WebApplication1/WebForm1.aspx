<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="border-style: dashed groove outset hidden; background-color: #00FFFF; font-family: 'Arial Black'; font-size: x-large; font-weight: bold;">
     my first divison in webform
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
        <div style="border-style: double groove dotted hidden; background-color: #FF00FF; font-family: 'Arial Black'; font-size: large; font-style: italic;">my second divison in webform<br />
            <br />
            <br />
        </div>
        <div style="border-style: double groove dotted hidden; background-color: #FFFF00; font-family: 'Arial Black'; font-size: x-large; font-style: italic;">my third divison in webform<br />
            <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
            <br />
        </div>
    </form>
</body>
</html>
