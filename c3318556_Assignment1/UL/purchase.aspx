<%@ Page Title="GB - Purchase" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="purchase.aspx.cs" Inherits="c3318556_Assignment1.UL.purchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!--  
    Author: James Moon
    Last Updated: 3/6/2021
    Description: This is where the user enters their email (if they are a guest), their card detials and their prefered
        delivery address. The card validation checks to make sure the card details are valid and correctly formatted
        and fails if it is not correct.
-->
    <h1>Payment Page</h1>
    <p>Please enter your payment details and your address below and we will automatically process your payment.</p>
    <p>The total amount you card will be charged: $<asp:Label ID="lblTotal" Text="(ERROR, NO PAYMENT FOUND)" runat="server" /></p>
    <br />
    <asp:Label ID="lblGuestEmail" Text="We have detected you have not logged in. In order to complete this transaction, please enter your email so we can send you a digital receipt." runat="server" />
    <asp:Table ID="tblGuestCheckout" CssClass="purchaseTable centerLogin tableBorder" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblEmail" Text="Email: " runat="server" /></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txbxEmail" placeholder="Email" runat="server" /></asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <table class="purchaseTable centerLogin tableBorder">
        <tr>
            <td>
                <label class="right">Name: </label>
            </td>
            <td>
                <asp:TextBox ID="txbxName" placeholder="Name on Card" runat="server" CssClass="largeTextBox" /></td>
        </tr>
        <tr>
            <td>
                <label class="right">Card Number: </label>
            </td>
            <td>
                <asp:TextBox ID="txbxCardNumber" placeholder="Number on Card" runat="server" CssClass="largeTextBox" /></td>
        </tr>
        <tr>
            <td>
                <label class="right">Expiry: </label>
            </td>
            <td>
                <asp:TextBox ID="txbxExpiryMonth" placeholder="XX" runat="server" CssClass="left largeTextBox" Width="200px" /><asp:TextBox ID="txbxExpiryYear" placeholder="XXXX" runat="server" CssClass="right largeTextBox" Width="200px" /></td>
        </tr>
        <tr>
            <td>
                <label class="right">CCV: </label>
            </td>
            <td>
                <asp:TextBox ID="txbxCVV" placeholder="CVV" runat="server" CssClass="largeTextBox" /></td>
        </tr>
    </table>
    <table class="purchaseTable centerLogin tableBorder">
        <tr>
            <td>
                <label class="right">Street Number: </label>
            </td>
            <td>
                <asp:TextBox ID="txbxStreetNo" placeholder="Street No." runat="server" CssClass="largeTextBox" /></td>
        </tr>
        <tr>
            <td>
                <label class="right">Street Name: </label>
            </td>
            <td>
                <asp:TextBox ID="txbxStreetName" placeholder="Street Name" runat="server" CssClass="largeTextBox" /></td>
        </tr>
        <tr>
            <td>
                <label class="right">Town/City: </label>
            </td>
            <td>
                <asp:TextBox ID="txbxTown" placeholder="Town/City" runat="server" CssClass="largeTextBox" /></td>
        </tr>
        <tr>
            <td>
                <label class="right">State: </label>
            </td>
            <td>
                <asp:TextBox ID="txbxState" placeholder="State" runat="server" CssClass="largeTextBox" /></td>
        </tr>
        <tr>
            <td>
                <label class="right">Postcode </label>
            </td>
            <td>
                <asp:TextBox ID="txbxPostCode" placeholder="Postcode" runat="server" CssClass="largeTextBox" /></td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnCancel" Text="Cancel" runat="server" CssClass="right centerTextButton" OnClick="btnCancel_Click" />
    <asp:Button ID="btnPay" Text="Pay" runat="server" CssClass="right centerTextButton" OnClick="btnPay_Click" />
    <asp:Label ID="lblFeedback" CssClass="right aligncenter" runat="server" />
</asp:Content>
