<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="c3318556_Assignment1.UL.register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
                <td>Home Address:</td>
                <td>
                    <asp:TextBox ID="postalAddress" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="existingUser" Text="Already a User? Log In" runat="server" OnClick="existingUser_Click" /></td>
                <td><asp:Button ID="registerNow" Text="Register" runat="server" OnClick="registerNow_Click" /></td>
            </tr>
        </table>
        <asp:Label ID="lblFeedback" runat="server" />
    </div>
</asp:Content>
