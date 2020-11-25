<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="fangying.aspx.cs" Inherits="WebApp.Frontpage.fangying" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <title>放映</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jqq">
        <div class="jqq_1">
            <ul>
                <li class="li_9">放映厅</li>
                <li class="li_7">|</li>
                <li class="li_8"><a href="#">近期活动</a></li>
                <li class="li_7">|</li>
                <li class="li_8"><a href="#">新闻中心</a></li>
            </ul>
        </div>
    </div>

    <div class="clear"></div>
    <asp:Repeater ID="RepVideoList" runat="server">
        <ItemTemplate>
            <div class="xia">
                <div class="xia_1">
                    <div class="xia_1_1">
                        <h1>赢鼎资讯</h1>
                        <h2>Welcome to yingding education</h2>
                    </div>
                    <div class="xia_1_2">
                        <ul>
                            <li>当前位置：</li>
                            <li><a href="#">首页</a> &gt;</li>
                            <li><a href="#">关于我们</a> &gt;</li>
                            <li class="li_6">&nbsp;放映厅</li>
                        </ul>
                    </div>
                </div>
                <div class="xia_2">
                    <div class="xia_2_1">
                        <h2><a href="#"><%#Eval("Video_Title") %></a><span>Time:<%#Eval("Video_CreateTime") %> </span></h2>
                    </div>
                    <div class="xia_3">
                        <ul>
                            <li><%#Eval("Video_Intro") %></li>
                        </ul>
                    </div>
                    <div class="xia_4">
                        <div class="xia_4_1" >
                            <a href="#">
                                <iframe  width="800px" height="500px"  src="<%#Eval("Video_Path") %>" allowFullScreen="true"></iframe>
                        </div>
                    </div>
                    <div class="xia_5">
                        <div class="xia_5_1">
                            <a href="fangying1.aspx">
                                <img src="assets/images1/fanhui.jpg" /></a>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
