<%@ Page Title="GB - Login" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="c3318556_Assignment1.UL.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3:13pm 3/4/2021
    Description: A reltively straight forward login screen including email and password. The emails and passwords are hard
        coded into the website until databases are linked. If you didnt read the README.txt, the logins are:

            Admin:
                Email: admin@yopmail.com
                Password: Pas5word

            User: 
                Email: user@yopmail.com
                Password: Pas5word

            Deactivated:
                Email: deactivated@yopmail.com
                Password: Pas5word

-->
    <h1>Login Page</h1>
    <p>You can log onto your account by entering your email and password in the sections below.</p>
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
                    <asp:Button ID="btnLogin" Text="Login" runat="server" OnClientClick="register.aspx" OnClick="btnLogin_Click" /></td>
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
