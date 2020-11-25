<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="zixun1.aspx.cs" Inherits="WebApp.Frontpage.zixun1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <title>资讯1</title>
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
        <div class="xia_2">
            <div class="xia_2_1">
                <h2>
                    <a href="#">
                        <asp:Label ID="txtTitle" runat="server" Text="Label"></asp:Label>
                    </a>
                    <span>Time: <asp:Label ID="txtTime" runat="server" Text="Label"></asp:Label></span></h2>
            </div>
            <div class="xia_3">
                <ul>
                    <li><asp:Label ID="txtIntro" runat="server" Text="Label"></asp:Label></li>
                </ul>
            </div>
            <div class="xia_4">
                <div class="xia_4_15">
                    <a href="#">
                        <img src='../../upload/News/<%=imgUrl %>' /></a>
                </div>

                <div class="xia_3a">
                    <ul>
                        <li>
                            <asp:Label ID="txtContent" runat="server" Text="Label"></asp:Label></li>
                    </ul>
                </div>

            </div>
            <div class="xia_5">
                <div class="xia_5_1">
                    <a href="zixun.aspx">
                        <img src="assets/images1/fanhui.jpg" /></a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
