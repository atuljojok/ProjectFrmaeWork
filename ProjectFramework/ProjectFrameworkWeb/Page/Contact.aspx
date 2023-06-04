<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ProjectFrameworkWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <h2><%: Title %>.</h2>
     <div>
       <div>
           <h2 class="text-center">Contact Details</h2>
       </div>
         <div style="padding-left:10rem">
              <asp:Label ID="LabelName" runat="server" Text="Label" Font-Size="Large"></asp:Label> <br />
              <asp:Label ID="LabelAdress" runat="server" Text="Label" Font-Size="Medium"></asp:Label>  <br />
              <asp:Label ID="LabelWeb" runat="server" Text="Label" Font-Size="Medium"></asp:Label> <br />
              <asp:Label ID="LabelNum" runat="server" Text="Label" Font-Size="Medium"></asp:Label> <br /> 
   
         </div>
    </div>
   
</asp:Content>
