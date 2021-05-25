<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="c3318556_Assignment1.UL.register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3:25pm 3/4/2021
    Description: This page is used for registering a new user. It doubles as an admin register if the current user is also an
        admin. User's enter their details and upon submitting, are sent an email with a randomly generated verification number.
        Upon successfully entering the correct verification number, they are redirected home. Admins are redirected home with
        the admin privileges and navigation differences to users.
-->
    <h1>Registration Page<asp:Label ID="lblAdminMaker" runat="server" Text="(Admin)" Visible="false" /></h1>
    <p>Each field is required in order to be registered with this site. Please make sure very field is filled before proceeding (You will be prompted if a field is unfilled).</p>
    <div class="centerLogin">
        <table class="registerTable">
            <tr>
                <td colspan="2" class="tabletop">Register
                </td>
            </tr>
            <tr>
                <td>First Name:</td>
                <td>
                    <asp:TextBox ID="firstName" runat="server" /></td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="lastName" runat="server" /></td>
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
                <td>Mobile Number:</td>
                <td>
                    <asp:TextBox ID="mobile" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblVerification" Text="Verification Key" runat="server" /></td>
                <td><asp:TextBox ID="txbxVerificationKey" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="existingUser" Text="Already a User? Log In" runat="server" OnClick="existingUser_Click" /></td>
                <td><asp:Button ID="registerNow" Text="Register" runat="server" OnClick="registerNow_Click" /><asp:Button ID="btnVerify" Text="Verify" runat="server" OnClick="btnVerify_Click"/></td>
            </tr>
        </table>
        <asp:Label ID="lblFeedback" runat="server" />
    </div>
</asp:Content>
