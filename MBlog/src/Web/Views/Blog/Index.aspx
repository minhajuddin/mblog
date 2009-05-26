<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBlog.Core.Domain.Model.Post>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
  <%=Html.GetSiteName() %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div id="posts">
    <ul>
      <%foreach (var item in Model) { %>
      <li class="post-gist">
        <h3>
          <%=Html.Anchor(Url.GetPermaLink(item), item.Title) %>
        </h3>
        <div class="gist">
          <%=item.Gist %>
        </div>
        <div class="post-info">
          <span class="post-author">
            <%=item.Author %></span> <span class="post-date">
              <%=item.Timestamp.ToString("MM/dd/yyyy hh:mm:ss") %></span>
        </div>
      </li>
      <%} %>
    </ul>
  </div>
</asp:Content>
