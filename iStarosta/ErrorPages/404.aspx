<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="ErrorPage.Master" CodeBehind="404.aspx.cs"
    Inherits="iStarosta.ErrorPages._404" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mvl ptm uiInterstitial uiInterstitialLarge uiBoxWhite">
        <div class="uiHeader uiHeaderWithImage uiHeaderBottomBorder mhl mts uiHeaderPage interstitialHeader">
            <div class="clearfix uiHeaderTop">
                <div class="rfloat">
                    <h2>
                        <img alt='' src="../Design/img/no.png" height="20px" />
                        Запрашиваемая вами страница не найдена.</h2>
                    <div class="uiHeaderActions">
                    </div>
                </div>
            </div>
        </div>
        <div class="phl ptm uiInterstitialContent">
            <div>
                Вы нажали на устаревшую ссылку или неправильно набрали адрес. Некоторые веб-сайты
                чувствительны к регистру.</div>
            <ul class="uiList mtm _4of _4kg">
                <li>
                    <div class="fcb">
                        <a href="/news">Вернуться на главную страницу iStarosta</a></div>
                </li>
                <li>
                    <div class="fcb">
                        <a href="javascript:goback()">Вернуться на предыдущую страницу</a></div>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
