<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="c3318556_Assignment1.UL.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Shopping Cart</h1>
    <div>
    <asp:Table ID="tblCart" runat="server" CssClass="tableCart">
        <asp:TableRow CssClass="aspRow">
            <asp:TableHeaderCell>Item</asp:TableHeaderCell>
            <asp:TableHeaderCell>Quantity</asp:TableHeaderCell>
            <asp:TableHeaderCell>Price</asp:TableHeaderCell>
        </asp:TableRow>
        <asp:TableRow CssClass="aspRow">
            <asp:TableCell>Product 1</asp:TableCell>
            <asp:TableCell>Product 1 Quantity</asp:TableCell>
            <asp:TableCell>Product 1 Price</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow CssClass="aspRow">
            <asp:TableCell>Product 2</asp:TableCell>
            <asp:TableCell>Product 2 Quantity</asp:TableCell>
            <asp:TableCell>Product 2 Price</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow CssClass="aspRow">
            <asp:TableCell>Product 3</asp:TableCell>
            <asp:TableCell>Product 3 Quantity</asp:TableCell>
            <asp:TableCell>Product 3 Price</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow CssClass="aspRow">
            <asp:TableCell>Product 4</asp:TableCell>
            <asp:TableCell>Product 4 Quantity</asp:TableCell>
            <asp:TableCell>Product 4 Price</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow CssClass="aspRow">
            <asp:TableCell>Product 5</asp:TableCell>
            <asp:TableCell>Product 5 Quantity</asp:TableCell>
            <asp:TableCell>Product 5 Price</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        </div>
    <div class="rightCart">
        <p>Your payment will be handled by card transaction on the next screen</p>
    </div>
</asp:Content>
