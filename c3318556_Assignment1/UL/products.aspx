<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="c3318556_Assignment1.UL.products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Products</h1>
    <p>We have a small range of motor vehicles to choose from, with mroe to hopefulyl be added to GarageBay. Stay tuned to see what new stock will have to offer!</p>
    <table class="product">
        <tr>
            <td>
                <img src="IMG/product5.jpg" class="pImage" /></td>
            <td class="pInfo">
                <h1>1921 Hudson Phaeton</h1>
                <h2>$25,000 AUD</h2>
                <h3>Manufacturer: Hudson Motors</h3>
                <p>This car was produced in 1921 by Hudson Motors for the mid-high range car buyer.</p>
                <asp:Button ID="cartProduct1" runat="server" Text="Add to Cart" CssClass="addToCart" OnClick="cartProduct1_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <img src="IMG/product4.jpg" class="pImage" />
            </td>
            <td class="pInfo">
                <h1>1956 Ford Thunderbird</h1>
                <h2>$46,000 AUD</h2>
                <h3>Manufacturer: Ford</h3>
                <p>This car was produced in 1921 by Ford Motor Group for the mid range car buyer. It included a fold-back roof and a curved exterior or a sleeker finish.</p>
                <asp:Button ID="cartProduct2" runat="server" Text="Add to Cart" CssClass="addToCart" OnClick="cartProduct2_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <img src="IMG/product3.jpg" class="pImage" />
            </td>
            <td class="pInfo">
                <h1>1949 Holden FX 48-215</h1>
                <h2>$23,000 AUD</h2>
                <h3>Manufacturer: General Motors Holden</h3>
                <p>This car was produced in 1949 by General Motors Holden for the mid range car buyer. Made to be the ideal and allround car for Australian people.</p>
                <asp:Button ID="cartProduct3" runat="server" Text="Add to Cart" CssClass="addToCart" OnClick="cartProduct3_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <img src="IMG/product2.jpg" class="pImage" />
            </td>
            <td class="pInfo">
                <h1>1968 Holden Monaro</h1>
                <h2>$34,000 AUD</h2>
                <h3>Manufacturer: General Motors Holden</h3>
                <p>This car was produced in 1968 by Geeral Motors Holden for the mid-high range car buyer. Made to be the ideal and allround sports car for Austrlaian people.</p>
                <asp:Button ID="cartProduct4" runat="server" Text="Add to Cart" CssClass="addToCart" OnClick="cartProduct4_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <img src="IMG/product1.jpg" class="pImage" />
            </td>
            <td class="pInfo">
                <h1>1940 Chevrolet Master Deluxe</h1>
                <h2>$43,000 AUD</h2>
                <h3>Manufacturer: Chevrolet</h3>
                <p>This car was produced in 1940 by Chevrolet for the high range car buyer. Its sleek finish and modded engine made it ideal for the high end car enthusiest.</p>
                <asp:Button ID="cartProduct5" runat="server" Text="Add to Cart" CssClass="addToCart" OnClick="cartProduct5_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
