<%@ Page Title="GB - Invoice" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="invoice.aspx.cs" Inherits="c3318556_Assignment1.UL.invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3/6/2021
    Description: Once a payment is completed, this page will show transaction details and a transaction id. This is then shown on user.aspx page.
-->
    <h1>Invoice</h1>
    <p>Congratulations on your new purchase! Please expect an email with your payment invoice in the next 24 hours! Any queries can be brought up with our support team under the Contact Us page. Your purchase should also appear under your user profile by clicking on your name on the navigation bar.</p>
    <p><b><u>Invoice ID:</u></b></p> <asp:Label ID="lblInvoiceID" runat="server" />
    <p><b><u>Transaction ID:</u></b></p> <asp:Label ID="lblTransactionID" runat="server" />
    <p><b><u>Success:</u></b></p> <asp:Label ID="lblSuccess" runat="server" />
    <p><b><u>Date & Time of purchase:</u></b></p> <asp:Label ID="lblDateTime" runat="server" />
    <asp:Button ID="btnReturn" Text="Return Home" runat="server" OnClick="btnReturn_Click" />
</asp:Content>
