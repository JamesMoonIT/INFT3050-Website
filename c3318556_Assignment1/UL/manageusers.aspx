<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="manageusers.aspx.cs" Inherits="c3318556_Assignment1.UL.manageusers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3:19pm 3/4/2021
    Description: An admin only page that manages the users on the website. Until it is linked, it has no purpose apart form
        it current formatting style and buttons for later navigation of records.
-->
    <h1>Manage Users</h1>
    <p>With the abilities and permissions of admin, you can manage active users and add/remove them from the website.</p>
    <asp:Table ID="tblUserTable" runat="server" CssClass="adminUserTable" >
        <asp:TableHeaderRow>
            <asp:TableHeaderCell></asp:TableHeaderCell>
            <asp:TableHeaderCell>First Name</asp:TableHeaderCell>
            <asp:TableHeaderCell>Last Name</asp:TableHeaderCell>
            <asp:TableHeaderCell>Email</asp:TableHeaderCell>
            <asp:TableHeaderCell>Phone Number</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell><asp:RadioButton ID="rbSelect1" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblFirstName1" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblLastName1" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblEmail1" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblPhone1" runat="server" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:RadioButton ID="rbSelect2" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblFirstName2" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblLastName2" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblEmail2" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblPhone2" runat="server" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:RadioButton ID="rbSelect3" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblFirstName3" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblLastName3" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblEmail3" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblPhone3" runat="server" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:RadioButton ID="rbSelect4" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblFirstName4" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblLastName4" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblEmail4" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblPhone4" runat="server" /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:RadioButton ID="rbSelect5" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblFirstName5" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblLastName5" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblEmail5" runat="server" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblPhone5" runat="server" /></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="btnPreviousFive" Text="View Previous 5 Records"  runat="server" OnClick="btnPreviousFive_Click" />
    <asp:Button ID="btnNextFive" Text="View Next 5 Records" runat="server" OnClick="btnNextFive_Click" />s
    
</asp:Content>
