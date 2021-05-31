<%@ Page Title="GB - Edit Products" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="adminproducts.aspx.cs" Inherits="c3318556_Assignment1.UL.Admin.adminproducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Edit Products</h1>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="productID" DataSourceID="c3318556_SQLDatabase" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="productID" HeaderText="productID" InsertVisible="False" ReadOnly="True" SortExpression="productID" />
            <asp:BoundField DataField="pName" HeaderText="pName" SortExpression="pName" />
            <asp:BoundField DataField="pBrand" HeaderText="pBrand" SortExpression="pBrand" />
            <asp:BoundField DataField="pType" HeaderText="pType" SortExpression="pType" />
            <asp:BoundField DataField="pModel" HeaderText="pModel" SortExpression="pModel" />
            <asp:BoundField DataField="pDesc" HeaderText="pDesc" SortExpression="pDesc" />
            <asp:BoundField DataField="pPrice" HeaderText="pPrice" SortExpression="pPrice" />
            <asp:BoundField DataField="pImage" HeaderText="pImage" SortExpression="pImage" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <asp:SqlDataSource ID="c3318556_SQLDatabase" runat="server" ConnectionString="<%$ ConnectionStrings:c3318556_SQLDatabaseConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [productID] = @productID" InsertCommand="INSERT INTO [Product] ([pName], [pBrand], [pType], [pModel], [pDesc], [pPrice]) VALUES (@pName, @pBrand, @pType, @pModel, @pDesc, @pPrice)" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE [Product] SET [pName] = @pName, [pBrand] = @pBrand, [pType] = @pType, [pModel] = @pModel, [pDesc] = @pDesc, [pPrice] = @pPrice WHERE [productID] = @productID">
        <DeleteParameters>
            <asp:Parameter Name="productID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="pName" Type="String" />
            <asp:Parameter Name="pBrand" Type="String" />
            <asp:Parameter Name="pType" Type="String" />
            <asp:Parameter Name="pModel" Type="String" />
            <asp:Parameter Name="pDesc" Type="String" />
            <asp:Parameter Name="pPrice" Type="Decimal" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="pName" Type="String" />
            <asp:Parameter Name="pBrand" Type="String" />
            <asp:Parameter Name="pType" Type="String" />
            <asp:Parameter Name="pModel" Type="String" />
            <asp:Parameter Name="pDesc" Type="String" />
            <asp:Parameter Name="pPrice" Type="Decimal" />
            <asp:Parameter Name="productID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </asp:Content>
