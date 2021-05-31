<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="adminmanageusers.aspx.cs" Inherits="c3318556_Assignment1.UL.Admin.adminmanageusers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--  
    Author: James Moon
    Last Updated: 3:19pm 3/4/2021
    Description: An admin only page that manages the users on the website. Until it is linked, it has no purpose apart form
        it current formatting style and buttons for later navigation of records.
-->
    <h1>Manage Users</h1>
    <p>With the abilities and permissions of admin, you can manage active users and add/remove them from the website.</p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:c3318556_SQLDatabaseConnectionString %>" SelectCommand="SELECT * FROM [Account]" DeleteCommand="DELETE FROM [Account] WHERE [userID] = @userID" InsertCommand="INSERT INTO [Account] ([emailAddress], [firstName], [lastName], [mobile], [adminPrivlages], [dateTime], [isActive], [addressID]) VALUES (@emailAddress, @firstName, @lastName, @mobile, @adminPrivlages, @dateTime, @isActive, @addressID)" UpdateCommand="UPDATE [Account] SET [emailAddress] = @emailAddress, [firstName] = @firstName, [lastName] = @lastName, [mobile] = @mobile, [adminPrivlages] = @adminPrivlages, [dateTime] = @dateTime, [isActive] = @isActive, [addressID] = @addressID WHERE [userID] = @userID">
        <DeleteParameters>
            <asp:Parameter Name="userID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="emailAddress" Type="String" />
            <asp:Parameter Name="firstName" Type="String" />
            <asp:Parameter Name="lastName" Type="String" />
            <asp:Parameter Name="mobile" Type="Int32" />
            <asp:Parameter Name="adminPrivlages" Type="Boolean" />
            <asp:Parameter Name="dateTime" Type="DateTime" />
            <asp:Parameter Name="isActive" Type="Boolean" />
            <asp:Parameter Name="addressID" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="emailAddress" Type="String" />
            <asp:Parameter Name="firstName" Type="String" />
            <asp:Parameter Name="lastName" Type="String" />
            <asp:Parameter Name="mobile" Type="Int32" />
            <asp:Parameter Name="adminPrivlages" Type="Boolean" />
            <asp:Parameter Name="dateTime" Type="DateTime" />
            <asp:Parameter Name="isActive" Type="Boolean" />
            <asp:Parameter Name="addressID" Type="Int32" />
            <asp:Parameter Name="userID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="userID" DataSourceID="SqlDataSource1" Width="100%" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="userID" HeaderText="userID" InsertVisible="False" ReadOnly="True" SortExpression="userID" />
            <asp:BoundField DataField="emailAddress" HeaderText="emailAddress" SortExpression="emailAddress" />
            <asp:BoundField DataField="firstName" HeaderText="firstName" SortExpression="firstName" />
            <asp:BoundField DataField="lastName" HeaderText="lastName" SortExpression="lastName" />
            <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
            <asp:CheckBoxField DataField="adminPrivlages" HeaderText="adminPrivlages" SortExpression="adminPrivlages" />
            <asp:BoundField DataField="dateTime" HeaderText="dateTime" SortExpression="dateTime" />
            <asp:CheckBoxField DataField="isActive" HeaderText="isActive" SortExpression="isActive" />
            <asp:BoundField DataField="addressID" HeaderText="addressID" SortExpression="addressID" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="Gray" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
</asp:Content>
