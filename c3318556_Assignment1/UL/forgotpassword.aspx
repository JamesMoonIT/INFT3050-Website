<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="forgotpassword.aspx.cs" Inherits="c3318556_Assignment1.UL.forgotpassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3:07pm 3/4/2021
    Description: This page will send an email to your desired email address. At the moment, it is hardcoded to send you
        the message: "Your password is: password". It makes sense with the hard-coded account, but you can also jsut put
        any email in and it will tell you your password is password. Email validation works though.
-->
    <div class="contactPage">
        <h1>Forgot Password</h1>
        <p>Please enter your email to verify you are the owner of the account:</p>
        <asp:TextBox ID="txbxEmail" runat="server" placeholder="Email"/>
        <asp:Button ID="btnRecover" runat="server" Text="Recover" OnClick="btnRecover_Click" />
        <asp:Label ID="lblFeedback" runat="server" />
        <br />
    </div>
</asp:Content>
