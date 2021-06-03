<%@ Page Title="GB - Products Page" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="productspage.aspx.cs" Inherits="c3318556_Assignment1.UL.products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3/6/2021
    Description: This is the products page where all current cars are listed for sale. You can buy as many as you
        want (apparently..) so there you go. The items are in a table that can be expanded with more products. kept it
        at 5 for coding purposes and lack of time.
-->
    <h1>Products</h1>
    <p>
        We have a small range of motor vehicles to choose from, with more to hopefully be added to GarageBay. Stay tuned to see what new stock will have to offer!   
    </p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:c3318556_SQLDatabaseConnectionString %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" CssClass="product" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="productID">
        <Columns>
            <asp:BoundField DataField="productID" SortExpression="productID" ReadOnly="true" HeaderText="ID" ItemStyle-Width="10%" Visible="false">
                <ItemStyle Width="10%"></ItemStyle>
            </asp:BoundField>
            <asp:TemplateField ItemStyle-Width="60%">
                <ItemTemplate>
                    <div class="product description">
                        <h1>
                            <asp:LinkButton ID="name" CommandArgument='<%#Eval("productID") %>' Text='<%#Eval("pname") %>' runat="server" OnCommand="name_Command" />
                        </h1>
                        <h2>AUD$<asp:Label ID="price" runat="server" Text='<%#Eval("pPrice") %>' /></h2>
                        <h3>Manufacturer:<asp:Label ID="brand" runat="server" Text='<%#Eval("pBrand") %>' /></h3>
                        <h3>Type:<asp:Label ID="type" runat="server" Text='<%#Eval("pType") %>' /></h3>
                        <h3>Model:<asp:Label ID="model" runat="server" Text='<%#Eval("pModel") %>' /></h3>
                        <p>
                            <asp:Label ID="description" runat="server" Text='<%#Eval("pDesc") %>' />
                        </p>
                        <p>
                            <asp:Button ID="addtocart" runat="server" Text="Add To Cart" CommandArgument='<%#Eval("productID") %>' OnCommand="addtocart_Command" />
                            <asp:Button ID="removefromcart" runat="server" Text="Remove From Cart" CommandArgument='<%#Eval("productID") %>' OnCommand="removefromcart_Command" />

                        </p>
                        <!-- <asp:label ID="feedback" runat="server" Text="Please login before adding items to cart" /> -->
                    </div>
                </ItemTemplate>

                <ItemStyle Width="50%"></ItemStyle>
            </asp:TemplateField>
            <asp:TemplateField ItemStyle-Width="40%">
                <ItemTemplate>
                    <asp:Image ID="pImage" runat="server" CssClass="pImage" Width="100%" ImageUrl='<%# Eval("pImage") %>' />
                </ItemTemplate>

                <ItemStyle Width="40%"></ItemStyle>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
