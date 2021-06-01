<%@ Page Title="GB - Products Page" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="productspage.aspx.cs" Inherits="c3318556_Assignment1.UL.products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--  
    Author: James Moon
    Last Updated: 3:22pm 3/4/2021
    Description: This is the products page where all current cars are listed for sale. You can buy as many as you
        want (apparently..) so there you go. The items are in a table that can be expanded with more products. kept it
        at 5 for coding purposes and lack of time.
-->
    <h1>Products</h1>
    <p>We have a small range of motor vehicles to choose from, with mroe to hopefulyl be added to GarageBay. Stay tuned to see what new stock will have to offer!
        <asp:GridView ID="GridView1" runat="server" CssClass="product" AutoGenerateColumns="False" DataSourceID="c3318556_SQLDatabase" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
        <Columns>
            <asp:BoundField DataField="pName" SortExpression="pName" HeaderText="Name"/>
            <asp:BoundField DataField="pBrand" SortExpression="pBrand" HeaderText="Brand" />
            <asp:BoundField DataField="pType" SortExpression="pType" HeaderText="Type" />
            <asp:BoundField DataField="pModel" SortExpression="pModel" HeaderText="Model" />
            <asp:BoundField DataField="pDesc" SortExpression="pDesc" HeaderText="Description" />
            <asp:BoundField DataField="pPrice" SortExpression="pPrice" HeaderText="Price" />
            <asp:BoundField DataField="pImage" SortExpression="pImage" HeaderText="Image" />
        </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="c3318556_SQLDatabase" runat="server" ConnectionString="<%$ ConnectionStrings:c3318556_SQLDatabaseConnectionString %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [pName], [pBrand], [pType], [pModel], [pDesc], [pPrice], [pImage] FROM [Product]">
        </asp:SqlDataSource>
    </p>


    <%--<asp:repeater id="productslist" runat="server">
        <headertemplate>
            <table class="product">
                <tr>
                    <td colspan="3"></td>
                </tr>
        </headertemplate>
        <itemtemplate>
            <tr>
                <td>
                    <img src="img/product5.jpg" class="pimage" /></td>
                <td class="pinfo">
                    <h1>
                        <asp:label id="name" runat="server" text='<%#eval("pname") %>' /></h1>
                    <h2>aud$
                        <asp:label id="price" runat="server" text='<%#eval("pprice") %>' /></h2>
                    <h3>manufacturer:
                        <asp:label id="brand" runat="server" text='<%#eval("pbrand") %>' /></h3>
                    <h3>type:
                        <asp:label id="type" runat="server" text='<%#eval("ptype") %>' /></h3>
                    <h3>model:
                        <asp:label id="model" runat="server" text='<%#eval("pmodel") %>' /></h3>
                    <p>
                        <asp:label id="description" runat="server" text='<%#eval("pdesc") %>' />
                    </p>
                    <asp:button id="cartproduct1" runat="server" text="add to cart" cssclass="addtocart" />
                </td>
            </tr>
            </table>
        </itemtemplate>
    </asp:repeater>--%>
</asp:Content>
