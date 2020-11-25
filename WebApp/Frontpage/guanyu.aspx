<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="guanyu.aspx.cs" Inherits="WebApp.Frontpage.guanyu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <title>关于</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jqq">
        <div class="jqq_1">
            <ul>
                <li class="li_11"><a href="#">赢鼎团队</a></li>
                <li class="li_7">|</li>
                <li class="li_8"><a href="#">赢鼎文化</a></li>
                <li class="li_7">|</li>
                <li class="li_8"><a href="#">赢鼎简介</a></li>
                <li class="li_7">|</li>
                <li class="li_12">总裁寄语</li>
            </ul>
        </div>
    </div>

    <div class="xia">
        <div class="xia_1">
            <div class="xia_1_1">
                <h1>关于我们</h1>
                <h2>Welcome to yingding education</h2>
            </div>
            <div class="xia_1_2">
                <ul>
                    <li>当前位置：</li>
                    <li><a href="#">首页</a> ></li>
                    <li><a href="#">关于我们</a> ></li>
                    <li class="li_6">&nbsp;总裁寄语</li>
                </ul>
            </div>
        </div>
        <asp:Repeater ID="RepSendList" runat="server">
            <ItemTemplate>
                <div class="xia_2s">
                    <div class="xia_2a">
                        <a href="#">
                            <img src='../../upload/Send/<%#Eval("Send_Image") %>' />
                    </div>
                    <div class="xia_2a_1">
                        <%#Eval("Send_Content") %>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
