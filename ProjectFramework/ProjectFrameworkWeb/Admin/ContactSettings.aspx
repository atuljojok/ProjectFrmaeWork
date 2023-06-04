<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="ContactSettings.aspx.cs" Inherits="ProjectFrameworkWeb.Admin.ContactSettings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="panel panel-primary">
      <div class="panel-heading"><h4>Configure Site Settings</h4></div>
      <div class="panel-body">

          <div class="form-group">
            <label for="TextBoxName"> Name</label>
                <asp:TextBox ID="TextBoxAppName" class="form-control"  style="min-width: 100%;" runat="server" Width="80%"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="TextBoxAdress">Adress</label>
                <asp:TextBox ID="TextBoxAdress" class="form-control" style="min-width: 100%;" runat="server" Width="80%" TextMode="MultiLine"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="TextBoxWeb">Web Url</label>
                <asp:TextBox ID="TextBoxWeb" class="form-control" style="min-width: 100%;" runat="server" TextMode="SingleLine" Width="80%"></asp:TextBox>
          </div>
           <div class="form-group">
            <label for="TextBoxNum">Contact Number</label>
                <asp:TextBox ID="TextBoxNum" class="form-control" style="min-width: 100%;" runat="server" TextMode="Number" Width="80%"></asp:TextBox>
          </div>
         
          <div class="form-group">
              <asp:Button ID="ButtonUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="ButtonUpdate_Click" />
              
          </div>
          <div class="form-group">
              <asp:Label ID="LabelStatus" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>
          </div>

      </div>
    </div>
</asp:Content>
