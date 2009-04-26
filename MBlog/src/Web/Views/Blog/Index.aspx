<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MBlog.Data.Domain.Post>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
  Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <h2>
    --Placeholder for the Blog title--</h2>
  <div id="posts">
    <ul>
      <%foreach (var item in Model) { %>
      <li>
        <h3>
          <%=item.Title %></h3>
        <p class="gist">
          <%=item.Gist %>
        </p>
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
