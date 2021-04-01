<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="c3318556_Assignment1.UL.user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Your user details:</h1>
    <p>First Name: <asp:Label ID="lblFirstName" Text="(FIRST NAME NOT FOUND)" runat="server" /></p>
    <p>Last Name: <asp:Label ID="lblLastName" Text="(LAST NAME NOT FOUND)" runat="server" /></p>
    <p>Email: <asp:Label ID="lblEmail" Text="(EMAIL NOT FOUND)" runat="server" /></p>
    <p>Mobile Number: <asp:Label ID="lblMobile" Text="(MOBILE NOT FOUND)" runat="server" /></p>
    <p>Address: <asp:Label ID="lblAddress" Text="(ADDRESS NOT FOUND)" runat="server" /></p>
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
</asp:Content>
