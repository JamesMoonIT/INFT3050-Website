﻿<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="adminregister.aspx.cs" Inherits="c3318556_Assignment1.UL.Admin.adminregister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Register Page (Admin)</h1>
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
                    <asp:TextBox ID="userPassword" TextMode="Password" runat="server" /></td>
            </tr>
            <tr>
                <td>Mobile Number:</td>
                <td>
                    <asp:TextBox ID="mobile" runat="server" /></td>
            </tr>
            <tr>
                <td> </td>
                <td> </td>
            </tr>
            <tr>
                <td>Street Number:</td>
                <td><asp:TextBox ID="streetNumber" runat="server" /></td>
            </tr>
            <tr>
                <td>Street Name:</td>
                <td><asp:TextBox ID="streetName" runat="server" /></td>
            </tr>
            <tr>
                <td>Suburb/Town:</td>
                <td><asp:TextBox ID="suburb" runat="server" /></td>
            </tr>
            <tr>
                <td>State:</td>
                <td><asp:TextBox ID="state" runat="server" /></td>
            </tr>
            <tr>
                <td>Postcode:</td>
                <td><asp:TextBox ID="postcode" runat="server" /></td>
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
