<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/iStarosta.Master" CodeBehind="NewsDetails.aspx.cs" Inherits="iStarosta.Content.NewsDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script>
    function goback() {
        history.go(-1);
    }
    </script>
<div class="allnews">
<div class="news">
<div class="headerNews">
<span class="title"><asp:Label ID="Label1" runat="server"/></span>
</div>
<div class="newsPage">
<div class="socialNetworks"></div>
<div class="picNews">
<asp:Image ID="Image1" runat="server" />
</div>

</div>
</div>
<div class="brand">
<asp:Label ID="Label2" runat="server"/>
<div class="more">
<a href="javascript:goback()">«« Перейти ко всем новостям</a>
</div>
</div></div>
</div>
<%--  <table>
        <tr>
            <td rowspan="3">
                <asp:Image ID="Image1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <div>
                    <br/>
                    <asp:Label ID="Label1" runat="server"/>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div>
                    <br/>
                    <asp:Label ID="Label2" runat="server"/><br/>
                </div>
            </td>
        </tr>
        <br />
        <br />
    </table>
    <br />--%>
</asp:Content>

