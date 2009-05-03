<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBlog.Data.Domain.Post>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
  <%=string.Format("{0} -- {1}", Html.GetSiteName(), Model.Title) %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <h2>
    <%=Html.Anchor(Url.GetPermaLink(Model), Model.Title) %>
  </h2>
  <div id="post-content">
    <%= Model.Content %>
  </div>
  <div id="post-info">
    <%= Html.Encode(Model.Author) %>
    <%=Html.Anchor(Url.GetPermaLink(Model),"Get Permalink",Model.Title)  %>
    <%=Html.Anchor(Url.GetShortenedUrl(Model),"Get Shortened Url",Model.Title)  %>
    <%= Html.Encode(String.Format("{0:g}", Model.Timestamp)) %>
  </div>
</asp:Content>
