<%@ Page Title="GB - Cart" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="c3318556_Assignment1.UL.cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--  
    Author: James Moon
    Last Updated: 3:01pm 3/4/2021
    Description: This page shows the shopping cart information the user sends to payment. Addmitedly, due to limited time, 
        I could not make it adaptive and has hard coded products in the cart. It features interactive buttons to add item
        to the cart. I also could not get it working where if you left cart, it would store the items (proven hard to code).
-->
    <h1>Shopping Cart</h1>
    <div class="leftcart">
        <asp:SqlDataSource ID="CartGrid" runat="server" ConnectionString="<%$ ConnectionStrings:c3318556_SQLDatabaseConnectionString %>" SelectCommand="SELECT * FROM [ShoppingCart] WHERE ([userID] = @userID)">
            <SelectParameters>
                <asp:SessionParameter Name="userID" SessionField="UserID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="CartGrid" DataKeyNames="cartID" GridLines="Horizontal" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="productID" HeaderText="productID" SortExpression="productID" />
                <asp:TemplateField HeaderText="Product">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" />
                        <asp:Label ID="lblPrice" runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <p>Name: <asp:Label ID="lblName" runat="server"/></p>
                        <p>Price: <asp:Label ID="lblPrice" runat="server"/></p>
                        <asp:SqlDataSource ID="ProductDetails" runat="server" ConnectionString="<%$ ConnectionStrings:c3318556_SQLDatabaseConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="productQuantity" HeaderText="Quantity" SortExpression="productQuantity" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblGuest" Visible="false" runat="server" Text="You must be logged in before adding items to a cart" />

    </div>
    <div class="rightCart" id="rightcart">
        <table class="centerTextButton">
            <tr>
                <td>
                    <p>
                        Your payment will be handled by card transaction on the next screen
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnPayment" Text="Proceed to Checkout" runat="server" OnClick="btnPayment_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
