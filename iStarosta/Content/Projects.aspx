<%@ Page Language="C#" MasterPageFile="~/MasterPages/iStarosta.Master" AutoEventWireup="true"
    CodeBehind="Projects.aspx.cs" Inherits="iStarosta.Content.Projects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        Проекты и направления Совета старост БГУ</h2>
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <p><b><%# Eval("Name")%>:</b> <%# Eval("Description")%></p>
            <%
                    if (User.IsInRole("moderator") || User.IsInRole("admin"))
                    {
                %>
                <div>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/ContentForModerator/EditProject.aspx?postId="+ Eval("Id") %>'>Редактировать</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "~/ContentForModerator/DeleteProject.aspx?postId="+ Eval("Id") %>'>Удалить</asp:HyperLink>
                </div>
                <%
                } %>
        </ItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT [id], [name], [description] FROM [projects]"></asp:SqlDataSource>

    <asp:HyperLink ID="AddProjectLink" NavigateUrl="~/ContentForModerator/AddProject.aspx"
        Visible="false" runat="server">Добавить проект</asp:HyperLink>
</asp:Content>
