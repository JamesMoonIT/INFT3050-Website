<%@ Page Title="GB - User Details" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="c3318556_Assignment1.UL.user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3:40pm 3/4/2021
    Description: This page acts as a stand in for when search works. It currently mentions it shows 5 results, and it redirects to the
        products page with a session variable "search" and the entered text (for later implementation).
-->
    <h1>Your user details:</h1>
    <p><b><u>First Name:</u></b> <asp:Label ID="lblFirstName" Text="(FIRST NAME NOT FOUND)" runat="server" /></p>
    <p><b><u>Last Name:</u></b> <asp:Label ID="lblLastName" Text="(LAST NAME NOT FOUND)" runat="server" /></p>
    <p><b><u>Email:</u></b> <asp:Label ID="lblEmail" Text="(EMAIL NOT FOUND)" runat="server" /></p>
    <p><b><u>Mobile Number:</u></b> <asp:Label ID="lblMobile" Text="(MOBILE NOT FOUND)" runat="server" /></p>
    <br />
    <h2>Purchase History:</h2>
    <p>Last 5 purchases:</p>
    <asp:Table runat="server" CssClass="purchaseHistory">
        <asp:TableHeaderRow>
            <asp:TableCell>Purchase</asp:TableCell>
            <asp:TableCell>Item</asp:TableCell>
            <asp:TableCell>Quantity</asp:TableCell>
            <asp:TableCell>Invoice ID</asp:TableCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>1</asp:TableCell>
            <asp:TableCell>No previous purchase</asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>2</asp:TableCell>
            <asp:TableCell>No previous purchase</asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>3</asp:TableCell>
            <asp:TableCell>No previous purchase</asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>4</asp:TableCell>
            <asp:TableCell>No previous purchase</asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>5</asp:TableCell>
            <asp:TableCell>No previous purchase</asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
</asp:Content>
