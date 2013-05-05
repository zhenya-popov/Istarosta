<%@ Page Language="C#" MasterPageFile="~/MasterPages/Profile.Master" AutoEventWireup="true"
    CodeBehind="MyGroup.aspx.cs" Inherits="iStarosta.ContentForUser.MyGroup" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <%# Eval("name")%> <%# Eval("surname")%>  <%# Eval("patronymic")%>  <%# Eval("phone")%> <%# Eval("email")%>
            <br />
            <%
                if (User.IsInRole("moderator") || User.IsInRole("admin"))
                {
            %>
            <div>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "~/ContentForUser/EditStudent.aspx?postId="+ Eval("Id") %>'>Edit</asp:HyperLink>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/ContentForUser/DeleteStudent.aspx?postId="+ Eval("Id") %>'>Delete</asp:HyperLink>
            </div>
            <%
                    } %>
        </ItemTemplate>
    </asp:Repeater>
    <asp:Button ID="Button1" runat="server" Text="Добавить" OnClick="Button1_Click" />
</asp:Content>
