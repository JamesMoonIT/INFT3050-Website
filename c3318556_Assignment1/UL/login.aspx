<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="c3318556_Assignment1.UL.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <table class="registerTable">
            <tr>
                <td colspan="2" class="tabletop">Login</td>
            </tr>
            <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="emailAddress" runat="server" /></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="userPassword" runat="server" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="newUser" Text="Not a User? Register Here!" runat="server" /></td>
                <td><asp:Button ID="registerButton" Text="Login" runat="server" OnClientClick="register.aspx" OnClick="registerButton_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
