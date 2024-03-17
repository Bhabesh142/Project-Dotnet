<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
                <td>Name:</td>
               
                 <td>   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                
                  <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Type a valid name" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <br />
                
                <br />
                
            <br/>
        NewPassword:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="enter a proper password" ControlToValidate="TextBox3" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                <br />
        <br/>  
        Retype Password:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="retype password" ControlToValidate="TextBox3" ForeColor="#CC0000" Display="Dynamic"></asp:RequiredFieldValidator>    
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="password and retype password must be same" ForeColor="#CC0000"></asp:CompareValidator>
                <br />
            <br/>Age:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox4" Display="Dynamic">

        </asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="value between 20 to 40" ForeColor="Red" MaximumValue="40" MinimumValue="20" Type="Integer"></asp:RangeValidator>
                <br />
                <br />
                Email:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="enter a valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <br />
                <br/>
            <asp:Button ID="Button1" runat="server" Text="SHOW" />
                <br />
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" HeaderText="Page error 1" />
    </table>

</asp:Content>



