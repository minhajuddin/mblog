<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MBlog.Core.Domain.Model.Post>"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
  <%=string.Format("{0} -- Create a Post", Html.GetSiteName()) %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <h2>
    Create a Post</h2>
  <%= Html.ValidationSummary("Aww Snap! Something went wrong, Please try again :(")%>
  <% using (Html.BeginForm()) {%>
  <fieldset>
    <p>
      <label for="Title">
        Title</label>
      <%= Html.TextBox("Title", "", new { style="width:600px;" })%>
      <%= Html.ValidationMessage("Title", "*") %>
    </p>
    <p>
      <label for="Content">
        Content</label>
      <%= Html.TextArea("Content", new { rows="20", cols="80" })%>
      <%= Html.ValidationMessage("Content", "*") %>
    </p>
    <p>
      <input type="submit" value="Publish" />
    </p>
  </fieldset>
  <% } %>
</asp:Content>
