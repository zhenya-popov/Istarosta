<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlbumDetails.aspx.cs"  MasterPageFile="~/MasterPages/iStarosta.Master"
 Inherits="iStarosta.Content.AlbumDetails" %>
 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ListView ID="ListView1" GroupItemCount="3" runat="server">
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
                <img alt="" height="250" src='<%# "../Design/img/photos/" + Eval("name")%>' />
                <div style="text-align: center; line-height: normal" align="center">
                    <p>
                        <strong><span style="font-size: 10pt">
                            <%# Eval("name")%></strong></p>
                </div>              
            </td>
        </ItemTemplate>
     </asp:ListView>
     <asp:FileUpload ID="FileUpload1" runat="server" Visible="false" />
     <asp:Button ID="Button1" runat="server" Visible="false" Text="Добавить" 
         onclick="Button1_Click" />
</asp:Content>

