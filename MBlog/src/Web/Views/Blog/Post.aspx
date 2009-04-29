<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBlog.Data.Domain.Post>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
  Post
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <h2>
    <%=Model.Title %></h2>
  <div id="post-content">
    <p>
      <%= Html.Encode(Model.Content) %>
    </p>
  </div>
  <div id="post-info">
    <%= Html.Encode(Model.Author) %>
    <%= Html.Encode(String.Format("{0:g}", Model.Timestamp)) %>
  </div>
</asp:Content>
