<%@ Page Title="GB - Product" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="c3318556_Assignment1.UL.product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="width50 left" >
        <h1>
            <asp:Label ID="productName" runat="server" /></h1>
        <p><u><b>Product ID:</b></u>
            <asp:Label ID="productID" runat="server" /></p>
        <p><u><b>Product Brand:</b></u>
            <asp:Label ID="productBrand" runat="server" /></p>
        <p><u><b>Product Type:</b></u>
            <asp:Label ID="productType" runat="server" /></p>
        <p><u><b>Product Model:</b></u>
            <asp:Label ID="productModel" runat="server" /></p>
        <p><u><b>Product Description:</b></u>
            <asp:Label ID="productDescription" runat="server" /></p>
        <p><u><b>Product Price: </b></u>AUD$ 
            <asp:Label ID="productPrice" runat="server" /></p>
    </div>
    <div class="width50 right">
        <asp:Image ID="pImage" runat="server"/>
    </div>
</asp:Content>
