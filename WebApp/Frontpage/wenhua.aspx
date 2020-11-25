<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="wenhua.aspx.cs" Inherits="WebApp.Frontpage.wenhua" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <title>文化</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jqq">
        <div class="jqq_1">
            <ul>
                <li class="li_11"><a href="#">赢鼎团队</a></li>
                <li class="li_7">|</li>
                <li class="li_13">赢鼎文化</li>
                <li class="li_7">|</li>
                <li class="li_8"><a href="#">赢鼎简介</a></li>
                <li class="li_7">|</li>
                <li class="li_8"><a href="#">赢鼎寄语</a></li>

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
                    <li class="li_6">&nbsp;赢鼎文化</li>
                </ul>
            </div>
        </div>
        <asp:Repeater ID="RepcultureList" runat="server">
            <ItemTemplate>
                <div class="wenhua"><%#Eval("culture_Intro") %></div>
                <div class="tu">
                    <div class="tu_1">
                        <h3><%#Eval("culture_Title1") %></h3>
                        <ul>
                            <li><%#Eval("culture_content1") %></li>
                        </ul>
                    </div>
                    <div class="tu_2">
                        <h3><%#Eval("culture_Title2") %></h3>
                        <ul>
                            <li><%#Eval("culture_content2") %></li>
                        </ul>
                    </div>
                    <div class="tu_3">
                        <h3><%#Eval("culture_Title3") %></h3>
                        <ul>
                            <li><%#Eval("culture_content3") %></li>
                        </ul>
                    </div>
                    <div class="tu_4">
                        <h3><%#Eval("culture_Title4") %></h3>
                        <ul>
                            <li><%#Eval("culture_content4") %></li>
                        </ul>
                    </div>
                    <div class="tu_1a">
                        <h3><%#Eval("culture_Title5") %></h3>
                        <ul>
                            <li><%#Eval("culture_content5") %></li>
                        </ul>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
