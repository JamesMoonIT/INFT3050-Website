<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="invoice.aspx.cs" Inherits="c3318556_Assignment1.UL.invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3:11pm 3/4/2021
    Description: There isnt too much to this page apart from if every form of validation on purchase.aspx is verified, it
        sends you here to say "Good job, you spent money on something you could never possibly get. How on earth do you
        expect us to ship this?". Wasnt really sure what else to put here.
-->
    <h1>Invoice</h1>
    <p>Congratulations on your new purchase! Please expect an email with your payment invoice in the next 24 hours! Any queries can be brought up with our support team under the Contact Us page. Your purchase should also appear under your user profile by clicking on your name on the navigation bar.</p>
    <asp:Button ID="btnReturn" Text="Return Home" runat="server" OnClick="btnReturn_Click" />
</asp:Content>
