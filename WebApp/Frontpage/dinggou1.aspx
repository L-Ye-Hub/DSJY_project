<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="dinggou1.aspx.cs" Inherits="WebApp.Frontpage.dinggou1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="../Admins/assets/vendor/bootstrap/css/bootstrap.min.css">
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <title>订购1</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bennera">
        <div class="benner_1a">
            <div class="benner_2a">
                <img src="assets/images1/tu13.jpg" />
            </div>
        </div>
    </div>

    <div class="jqq">
        <div class="jqq_1">
            <ul>
                <li class="li_9">在线订购</li>
                <li class="li_7">|</li>
                <li class="li_8"><a href="#">免费借书</a></li>

            </ul>
        </div>
    </div>

    <div class="xia">
        <div class="xia_1">
            <div class="xia_1_1">
                <h1>业务体系</h1>
                <h2>Welcome to yingding education</h2>
            </div>
            <div class="xia_1_2">
                <ul>
                    <li>当前位置：</li>
                    <li><a href="#">首页</a> ></li>
                    <li><a href="#">业务体系</a> ></li>
                    <li class="li_6">&nbsp;在线订购</li>
                </ul>
            </div>
        </div>
        <div class="jieshu">
            <img src="assets/images1/tu18.jpg" />
        </div>
        <div class="jieshu_1">
            <div class="dingyue_a">
                <div class="dingyue_1">
                    <a href="#">
                        <img src='../../upload/Product/<%=imgProduct %>' />
                    </a>
                </div>
                <div class="dingyue_1_1">
                    <div class="dingyue_2_a">
                        <h2>
                            <asp:Label ID="txtTitle" runat="server" Text="Label"></asp:Label></h2>
                        <div class="dingyue_2_1">
                            <ul>
                                <li class="li_a">标记</li>
                                <li class="li_b">
                                    <asp:Label ID="txtPrice" runat="server" Text="Label"></asp:Label></h2></li>
                                <li>元</li>
                            </ul>
                        </div>
                    </div>
                    <div class="dingyue_3a">
                        <ul>
                            <li>内容:</li>
                            <asp:Label ID="txtContent" runat="server" Text="Label"></asp:Label>
                        </ul>
                    </div>
                    <div class="dingyue_4a">
                        <a href='dinggou2.aspx?action=<%=ProductId %>'>
                            <img src="assets/images1/tu21.jpg" />
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
