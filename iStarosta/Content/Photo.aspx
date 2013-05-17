<%@ Page Language="C#" MasterPageFile="~/MasterPages/iStarosta.Master" AutoEventWireup="true"
    CodeBehind="Photo.aspx.cs" Inherits="iStarosta.Content.Photo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <table>
                <tr>
                    <td>
                     <a href="../Content/albums/Album.aspx">
                    <img alt="" height="250" src="../Design/img/album.png" class="album" /></a>
                    <%# Eval("name")%>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT [name] FROM [albums]"></asp:SqlDataSource>
    <table>
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
    </table>
</asp:Content>
