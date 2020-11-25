<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="zixun.aspx.cs" Inherits="WebApp.Frontpage.zixun" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <title>资讯</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jqq">
        <div class="jqq_1">
            <ul>
                <li class="li_15"><a href="#">放映厅</a></li>
                <li class="li_7">|</li>
                <li class="li_13">近期活动</li>
                <li class="li_7">|</li>
                <li class="li_8"><a href="#">新闻中心</a></li>
            </ul>
        </div>

    </div>

    <div class="xia">
        <div class="xia_1">
            <div class="xia_1_1">
                <h1>赢鼎资讯</h1>
                <h2>Welcome to yingding education</h2>
            </div>
            <div class="xia_1_2">
                <ul>
                    <li>当前位置：</li>
                    <li><a href="#">首页</a> ></li>
                    <li><a href="#">赢鼎资讯</a> ></li>
                    <li class="li_6">&nbsp;新闻中心</li>
                </ul>
            </div>
        </div>
        <asp:Repeater ID="RepNewsList" runat="server">
            <ItemTemplate>
                <div class="ying">
                    <div class="ying_1">
                        <div class="ying_1_1">
                            <a href="zixun1.aspx?action=<%#Eval("News_Id") %>">
                                <img src="../../upload/News/<%#Eval("News_Image ") %>" /></a>
                        </div>
                        <div class="ying_1_2">
                            <h2><a href="zixun1.aspx?action=<%#Eval("News_Id") %>"><%#Eval("News_Title") %></a></h2>
                            <ul>
                                <li><a href="zixun1.aspx?action=<%#Eval("News_Id") %>"><%#Eval("News_Intro") %></a></li>
                            </ul>
                        </div>
                        <div class="ying_1_3"><%#Eval("News_CreateTime") %></div>
                    </div>
                    <div class="ying_2">
                        <div class="ying_1_1">
                            <a href="#">
                                <img src="assets/images1/tu25.jpg" /></a>
                        </div>
                        <div class="ying_1_2a">
                            <h2><a href="#">高考报考学分享会在吉林成功举办</a></h2>
                            <ul>
                                <li><a href="#">2月16日，赢鼎教育高考报考学分享会在吉林市站前国际大酒店圆满落幕，赢鼎教育高级讲师，资深高考报考、学业、职业规划师……</a></li>
                            </ul>
                        </div>
                        <div class="ying_1_3">Time: 2014/05/26</div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class="ye"></div>
    </div>
    </div>
</asp:Content>
