<%@ Page Language="C#" MasterPageFile="~/iStarosta.Master" AutoEventWireup="true"
    CodeBehind="People.aspx.cs" Inherits="iStarosta.Content.People" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        Мы в социльном мире:&nbsp <a href="https://vk.com/istarosta_bsu" target="_blank">
            <img alt='' src="../Design/img/social/vk.png" title="Вконтакте" /></a><a href="https://twitter.com/iStarosta_BSU"
                target="_blank"><img src="../Design/img/social/twitter.png" title="Твиттер" /></a></h2>
    <br>
    <br />
    <asp:ListView ID="ListView1" DataSourceID="SqlDataSource1" GroupItemCount="3" runat="server">
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
                <img alt="" height="250" src='<%# "../Design/img/bsuPerson/" + Eval("imagelink")%>' />
                <div style="text-align: center; line-height: normal" align="center">
                    <p>
                        <strong><span style="font-size: 10pt">
                            <%# Eval("surname")%> <%# Eval("name")%>
                            <%# Eval("patronymic")%></span></strong></p>
                </div>
                <div style="text-align: center; line-height: normal" align="center">
                    <span style="font-size: 10pt">
                        <%# Eval("position")%></span></div>
                <div style="text-align: center; line-height: normal; margin: 12pt 0cm 0pt" align="center">
                    <span style="font-size: 10pt">
                        <%# Eval("faculty")%></span></div>
                <div style="text-align: center; line-height: normal; margin: 12pt 0cm 0pt" align="center">
                    <span style="font-size: 10pt">
                        <%# Eval("course")%>
                        курс</span></div>
                <div style="text-align: center; line-height: normal" align="center">
                    <span style="font-size: 10pt"><b>Контакты:</b></span></div>
                <div style="text-align: center; line-height: normal" align="center">
                    <span style="font-size: 10pt"><b>Телефон: </b>
                        <%# Eval("phonenumber")%></span></div>
                <div style="text-align: center; line-height: normal" align="center">
                    <span style="font-size: 10pt"><b>e-mail: </b>
                        <%# Eval("email")%></span></div>
                <div style="text-align: center; line-height: normal" align="center">
                    <span style="font-size: 10pt"><b>VK: </b>
                        <%# Eval("vkontakte")%></span></div>
                <%
                    if (User.IsInRole("moderator") || User.IsInRole("admin"))
                    {
                %>
                <div>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/ContentForModerator/EditPerson.aspx?postId="+ Eval("Id") %>'>Edit</asp:HyperLink>
                </div>
                <%
                } %>
            </td>
        </ItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT * FROM [userinfo]"></asp:SqlDataSource>
    <asp:HyperLink ID="AddUserLink" NavigateUrl="~/ContentForModerator/AddPerson.aspx"
        Visible="false" runat="server">Добавить в персоналии</asp:HyperLink>
</asp:Content>
