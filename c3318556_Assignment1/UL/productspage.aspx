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
    <p>
        We have a small range of motor vehicles to choose from, with mroe to hopefulyl be added to GarageBay. Stay tuned to see what new stock will have to offer!   
    </p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:c3318556_SQLDatabaseConnectionString %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" CssClass="product" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="productID">
        <Columns>
            <asp:BoundField DataField="productID" SortExpression="productID" ReadOnly="true" HeaderText="ID" />
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="product">
                        <h1>
                            <asp:LinkButton ID="name" runat="server" OnClick="name_Click" Text='<%#Eval("pname") %>' /></h1>
                        <h2>AUD$<asp:Label ID="price" runat="server" Text='<%#Eval("pprice") %>' /></h2>
                        <h3>Manufacturer:<asp:Label ID="brand" runat="server" Text='<%#Eval("pbrand") %>' /></h3>
                        <h3>Type:<asp:Label ID="type" runat="server" Text='<%#Eval("ptype") %>' /></h3>
                        <h3>Model:<asp:Label ID="model" runat="server" Text='<%#Eval("pmodel") %>' /></h3>
                        <p>
                            <asp:Label ID="description" runat="server" Text='<%#Eval("pdesc") %>' />
                        </p>
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Image ID="pImage" runat="server" CssClass="pImage" ImageUrl='<%# Eval("pImage") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>


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
