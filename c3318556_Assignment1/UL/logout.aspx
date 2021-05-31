<%@ Page Title="GB - Logout" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="c3318556_Assignment1.UL.logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3:17pm 3/4/2021
    Description: This is a very straight forward page. If your have a user id and you click yes, it will wipe the uid from the
        session and send you bck to home. At home, it will look for an id and will default to a regular login. If you click no,
        it just redirects you back to the home screen.
-->
    <h1>Logout</h1>
    <p class="aligncenter">Are you sure you want to logout?</p>
    <table class="aligncenter">
        <tr>
            <td><asp:Button ID="btnYes" Text="Yes" runat="server" OnClick="btnYes_Click" /></td>
            <td><asp:Button ID="btnNo" Text="No" runat="server" OnClick="btnNo_Click" /></td>
        </tr>
    </table>
</asp:Content>
