<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="forgotpassword.aspx.cs" Inherits="c3318556_Assignment1.UL.forgotpassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contactPage">
        <h1>Forgot Password</h1>
        <p>Please enter your email to verify you are the owner of the account:</p>
        <asp:TextBox ID="txbxEmail" runat="server" placeholder="Email"/>
        <asp:Button ID="btnRecover" runat="server" Text="Recover" OnClick="btnRecover_Click" />
        <br />
    </div>
</asp:Content>
