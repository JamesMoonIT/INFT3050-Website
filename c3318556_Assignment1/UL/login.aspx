<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="c3318556_Assignment1.UL.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="centerLogin">
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
                    <asp:TextBox ID="userPassword" runat="server" TextMode="Password" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="newUser" Text="Not a User? Register Here!" runat="server" OnClick="newUser_Click" /></td>
                <td>
                    <asp:Button ID="registerButton" Text="Login" runat="server" OnClientClick="register.aspx" OnClick="registerButton_Click" /></td>
            </tr>
        </table>
        <div>
            <br />
            <asp:Button ID="btnForgotPassword" Text="Forgot password?" runat="server" CssClass="transparentButton" OnClick="btnForgotPassword_Click" />
            <p></p>
            <asp:Label ID="lblFeedback" runat="server" />
        </div>
    </div>
</asp:Content>
