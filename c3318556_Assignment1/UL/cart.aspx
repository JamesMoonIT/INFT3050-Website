<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="c3318556_Assignment1.UL.cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3:01pm 3/4/2021
    Description: This page shows the shopping cart information the user sends to payment. Addmitedly, due to limited time, 
        I could not make it adaptive and has hard coded products in the cart. It features interactive buttons to add item
        to the cart. I also could not get it working where if you left cart, it would store the items (proven hard to code).
-->
    <h1>Shopping Cart</h1>
    <div>
        <asp:Table ID="tblCart" runat="server" CssClass="tableCart">
            <asp:TableRow CssClass="aspRow">
                <asp:TableHeaderCell>Item</asp:TableHeaderCell>
                <asp:TableHeaderCell>Quantity</asp:TableHeaderCell>
                <asp:TableHeaderCell>Price</asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow CssClass="aspRow">
                <asp:TableCell>1921 Hudson Phantom</asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="p1Subtract" runat="server" Text="-" OnClick="p1Subtract_Click" /><asp:Label ID="p1Quantity" runat="server" Text="0" />
                    <asp:Button ID="p1Add" runat="server" Text="+" OnClick="p1Add_Click" /></asp:TableCell>
                <asp:TableCell>$25,000</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="aspRow">
                <asp:TableCell>1956 Ford Thunderbird</asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="p2Subtract" runat="server" Text="-" OnClick="p2Subtract_Click" /><asp:Label ID="p2Quantity" runat="server" Text="0" />
                    <asp:Button ID="p2Add" runat="server" Text="+" OnClick="p2Add_Click" /></asp:TableCell>
                <asp:TableCell>$46,000</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="aspRow">
                <asp:TableCell>1949 Holden FX 48-215</asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="p3Subtract" runat="server" Text="-" OnClick="p3Subtract_Click" /><asp:Label ID="p3Quantity" runat="server" Text="0" />
                    <asp:Button ID="p3Add" runat="server" Text="+" OnClick="p3Add_Click" /></asp:TableCell>
                <asp:TableCell>$23,000</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="aspRow">
                <asp:TableCell>1968 Holden Monaro</asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="p4Subtract" runat="server" Text="-" OnClick="p4Subtract_Click" /><asp:Label ID="p4Quantity" runat="server" Text="0" />
                    <asp:Button ID="p4Add" runat="server" Text="+" OnClick="p4Add_Click" /></asp:TableCell>
                <asp:TableCell>$34,000</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="aspRow">
                <asp:TableCell>1940 Chevrolet Master Deluxe</asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="p5Subtract" runat="server" Text="-" OnClick="p5Subtract_Click" /><asp:Label ID="p5Quantity" runat="server" Text="0" />
                    <asp:Button ID="p5Add" runat="server" Text="+" OnClick="p5Add_Click" /></asp:TableCell>
                <asp:TableCell>$43,000</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <p>Total: $<asp:Label ID="lblTotalAmount" Text="0" runat="server" /></p>
    </div>
    <div class="rightCart">
        <table class="centerTextButton">
            <tr>
                <td>
                    <p>Your payment will be handled by card transaction on the next screen</p>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnPayment" Text="Proceed to Checkout" runat="server" OnClick="btnPayment_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
