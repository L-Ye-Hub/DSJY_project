<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="fangying1.aspx.cs" Inherits="WebApp.Frontpage.fangying1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <style>
        .img {
            height:122px;
            width:144px;
        }
    </style>
    <title>放映1</title>
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
        <asp:Repeater ID="RepVideoList" runat="server">
            <ItemTemplate>
                <div class="ying">
                    <div class="ying_1">
                        <div class="ying_1_1">
                            <a href="fangying.aspx?action=<%#Eval("Video_Id") %>"> 
                                <img src="../../upload/Video/<%#Eval("Video_Image ") %>" class="img"/>
                            </a>
                        </div>
                        <div class="ying_1_2">
                            <h2><a href="fangying.aspx?action=<%#Eval("Video_Id") %>"><%#Eval("Video_Title") %></a></h2>
                            <span>Time: <%#Eval("Video_CreateTime","{0:yyyy.MM.dd}") %> </span>
                        </div>
                    </div>
                    <div class="ying_2">
                        <div class="ying_1_1">
                            <a href="fangying.aspx?action=<%#Eval("Video_Id") %>">
                                <img src="../../upload/Video/<%#Eval("Video_Image ") %> " class="img"/>
                            </a>
                        </div>
                        <div class="ying_1_2a">
                            <h2><a href="fangying.aspx?action=<%#Eval("Video_Id") %>"><%#Eval("Video_Title") %></a></h2>
                            <span>Time: <%#Eval("Video_CreateTime","{0:yyyy.MM.dd}") %></span>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
                <div class="ye"></div>
                </div>
</asp:Content>
