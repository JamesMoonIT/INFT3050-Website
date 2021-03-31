<%@ Page Title="" Language="C#" MasterPageFile="~/UL/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="c3318556_Assignment1.UL.contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="centerLogin" style="width: 100%">
        <h1>Contact Us</h1>
        <p>Should any issues arise, you can leave us your feedback and we will get back to you in the next 24 hours with any assistance or infromation you may need or desire. Any feedback greatly assists with the development of this website. Thank you!</p>
        <table class="largeTextBox">
            <tr>
                <td>
                    <asp:TextBox ID="name" runat="server" placeholder="Name" width="40%"/></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="emailAddress" runat="server" placeholder="Email" Width="40%"/></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="emailSubject" runat="server" placeholder="Subject" Width="40%"/></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="question" runat="server" placeholder="Question" Width="40%" Height="50%" TextMode="MultiLine"/></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblSuccess" runat="server" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
