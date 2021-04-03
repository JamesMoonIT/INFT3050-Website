<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="c3318556_Assignment1.UL.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!-- 
   Author: James Moon
   Last Updated: 2:55pm
   Description: This Admin page allows any admin user to navigate admin-privlaged pages including Edit Product (which is
       just the products page with hidden buttons now visible to admins), Register Admin (login page with extra options),
       which is an admin only page to manage users (security on boot to make sure they are admin)
-->
    <h1>Admin</h1>
    <p>Please select a tool:</p>
    <table>
        <tr>
            <td><asp:Button ID="btnEditProducts" runat="server" Text="Edit Products" CssClass="adminButtons" OnClick="btnEditProducts_Click" /></td>
            <td><asp:Button ID="btnAddAdmin" runat="server" Text="Create Admin" CssClass="adminButtons" OnClick="btnAddAdmin_Click" /></td>
             <td><asp:Button ID="btnManageUsers" runat="server" Text="Manage Users" CssClass="adminButtons" OnClick="btnManageUsers_Click" /></td>
        </tr>
    </table>
</asp:Content>
