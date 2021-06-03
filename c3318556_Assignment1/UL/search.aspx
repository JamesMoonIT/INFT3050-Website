<%@ Page Title="GB - Search" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="c3318556_Assignment1.UL.search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3/6/2021
    Description: This page acts as a stand in for when search works. It currently mentions it shows 5 results, and it redirects to the
        products page with a session variable "search" and the entered text (for later implementation).
-->
    <h1>Search</h1>
    <p>Please enter the search term, product number or name of the item you are looking for and our very extraordinay algorithm will work its wonders to find your product your heart desires:</p>
    <div class="centerLogin">
        <asp:TextBox ID="searchBox" placeholder="Search" runat="server" CssClass="largeTextBox" />
        <table class="aligncenter">
            <tr>
                <td>
                    <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click"/></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblSearchResults" Text="Search Results: " runat="server" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="noResult" Text="Found 5 potential results :)" runat="server" CssClass="centerLabel" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnToProducts" runat="server" Text="To Results" CssClass="centerTextButton" OnClick="btnToProducts_Click" /> </td>
            </tr>
        </table>
    </div>
</asp:Content>
