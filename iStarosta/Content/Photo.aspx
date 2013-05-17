<%@ Page Language="C#" MasterPageFile="~/MasterPages/iStarosta.Master" AutoEventWireup="true"
    CodeBehind="Photo.aspx.cs" Inherits="iStarosta.Content.Photo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListView1" GroupItemCount="4" runat="server" DataSourceID="SqlDataSource1">
     <LayoutTemplate>
            <table cellpadding="2" runat="server" id="tblProducts">
                <tr runat="server" id="groupPlaceholder">
                </tr>
            </table>
        </LayoutTemplate>
        <GroupTemplate>
            <tr runat="server" id="productRow">
                <td runat="server" id="itemPlaceholder">
                </td>
            </tr>
        </GroupTemplate>
        <ItemTemplate>
            <td id="Td1" valign="top" align="center" runat="server">
                <a href='<%# "/Content/AlbumDetails.aspx?postId="+ Eval("Id") %>'>
                    <img alt="" height="250" src="../Design/img/album.png" class="album" /></a>
                <div style="text-align: center; line-height: normal" align="center">
                    <p>
                        <strong><span style="font-size: 10pt">
                            <%# Eval("name")%></strong></p>
                </div> 
                 <%
                    if (User.IsInRole("moderator") || User.IsInRole("admin"))
                    {
                %>
                <div>
                   <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "~/ContentForModerator/DeleteAlbum.aspx?postId="+ Eval("Id") %>'>Delete</asp:HyperLink>
                </div>
                <%
                } %>             
            </td>
        </ItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT * FROM [albums]"></asp:SqlDataSource>
        <asp:HyperLink ID="AddAlbumLink" NavigateUrl="~/ContentForModerator/AddAlbum.aspx"
        Visible="false" runat="server">Добавить альбом</asp:HyperLink>
<%--    <table>
        <tr>
            <td valign="top" align="center">
                <a href="../Content/albums/Album.aspx">
                    <img alt="" height="250" src="../Design/img/album.png" class="album" /></a>
                <div style="text-align: center; line-height: normal" align="center">
                    <a href="../Content/albums/Album.aspx">
                        <p>
                            <span style="font-size: 13px">Школа старост 2012</span></p>
                    </a>
                </div>
                <div style="text-align: center; line-height: normal" align="center">
                    <span style="font-size: 13px"><b>Фотограф:</b> Виктория Цвирко </span>
                </div>
            </td>
        </tr>
    </table>--%>
</asp:Content>
