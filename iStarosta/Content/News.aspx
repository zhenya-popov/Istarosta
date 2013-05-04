<%@ Page Language="C#" MasterPageFile="~/iStarosta.Master" AutoEventWireup="true"
    CodeBehind="News.aspx.cs" Inherits="iStarosta.Content.News" %>

<%@ Import Namespace="iStarosta.Content" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="AddNewsLink" NavigateUrl="~/ContentForModerator/AddNews.aspx"
        Visible="false" runat="server">Добавить новость</asp:HyperLink>
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="id">
        <ItemTemplate>
            <table style="width: 600px; margin: 0 auto" cellpadding="0" cellspacing="0">
                <tbody>
                    <tr>
                        <td valign="top" style="padding-left: 20px">
                            <div class="newsList">
                                <div class="item">
                                    <div class="pic">
                                        <img src="" alt="" /><asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Handlers/PictureHandler.ashx?imageName="+ Eval("ImageName") %>'
                                            CssClass="pic" /></div>
                                    <div class="date">
                                        <%# Eval("Postdate")%></div>
                                    <div class="title">
                                        <a href="#">
                                            <%# Eval("Title")%></a></div>
                                    <div class="descr">
                                        <%# Eval("Newscontent")%>
                                    </div>
                                    <div class="more">
                                        <a href='<%# "/Content/NewsDetails.aspx?postId="+ Eval("Id") %>'>подробнее »»</a>
                                        <%
                                            if (User.IsInRole("moderator") || User.IsInRole("admin"))
                                            {
                                        %>
                                        <a href='<%# "/ContentForModerator/EditNews.aspx?postId="+ Eval("Id") %>'>редактировать »»</a>
                                        <% } %>
                                    </div>
                                    <div class="clear">
                                    </div>
                                </div>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <%--<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/ContentForModerator/EditNews.aspx?postId="+ Eval("Id") %>'>Edit</asp:HyperLink>--%></div>
                    </tr>
                </tbody>
            </table>
            <div>
        </ItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT * FROM [news]"></asp:SqlDataSource>
    <asp:DataPager ID="DataPager1" PagedControlID="ListView1" PageSize="2" runat="server">
        <Fields>
            <asp:NumericPagerField ButtonType="Link" />
        </Fields>
    </asp:DataPager>
</asp:Content>
