<%@ Page Title="GB - Product" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="c3318556_Assignment1.UL.product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Product Name: <asp:Label ID="productName" runat="server" /></h1>
    <p>Product ID: <asp:Label ID="productID" runat="server" /></p>
    <p>Product Brand: <asp:Label ID="productBrand" runat="server" /></p>
    <p>Product Type: <asp:Label ID="productType" runat="server" /></p>
    <p>Product Model: <asp:Label ID="productModel" runat="server" /></p>
    <p>Product Description: <asp:Label ID="productDescription" runat="server" /></p>
    <p>Product Price: <asp:Label ID="productPrice" runat="server" /></p>
</asp:Content>
