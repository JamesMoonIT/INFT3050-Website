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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:c3318556_SQLDatabaseConnectionString %>" SelectCommand="SELECT * FROM [Account]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="userID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="userID" HeaderText="userID" ReadOnly="True" SortExpression="userID" />
            <asp:BoundField DataField="emailAddress" HeaderText="emailAddress" SortExpression="emailAddress" />
            <asp:BoundField DataField="firstName" HeaderText="firstName" SortExpression="firstName" />
            <asp:BoundField DataField="lastName" HeaderText="lastName" SortExpression="lastName" />
            <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
            <asp:CheckBoxField DataField="adminPrivlages" HeaderText="adminPrivlages" SortExpression="adminPrivlages" />
            <asp:BoundField DataField="dateTime" HeaderText="dateTime" SortExpression="dateTime" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnPreviousFive" Text="View Previous 5 Records"  runat="server" OnClick="btnPreviousFive_Click" />
    <asp:Button ID="btnNextFive" Text="View Next 5 Records" runat="server" OnClick="btnNextFive_Click" />
    
</asp:Content>
