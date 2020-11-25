<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="dinggou.aspx.cs" Inherits="WebApp.Frontpage.dinggou" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <title>订购</title>
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
                    <li><a href="#">首页</a> > </li>
                    <li><a href="#">业务体系</a>   > </li>
                    <li class="li_6">&nbsp;在线订购</li>
                </ul>
            </div>
        </div>
        <div class="jieshu">
            <img src="assets/images1/tu18.jpg" />
        </div>
        <div class="jieshu_1">
            <asp:Repeater ID="RepRolesList" runat="server">
                <ItemTemplate>
                    <div class="dingyue">
                        <div class="dingyue_1">
                            <a href="dinggou1.aspx?action=<%#Eval("Product_Id") %>">
                                <img src='../../upload/Product/<%#Eval("Product_Image") %>' />
                            </a>
                        </div>
                        <div class="dingyue_2">
                            <span><a href="dinggou1.aspx?action=<%#Eval("Product_Id") %>">查看详情</a></span>
                            <h2><a href="dinggou1.aspx?action=<%#Eval("Product_Id") %>"><%#Eval("Product_Title") %></a></h2>
                            <div class="dingyue_2_1">
                                <ul>
                                    <li class="li_a">标记</li>
                                    <li class="li_b"><%#Eval("Product_Price") %></li>
                                    <li>元</li>
                                </ul>
                            </div>
                            <div class="dingyue_3">简介：<%#Eval("Product_Intro") %></div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
        <div class="row">
            <div class="col-md-10 col-md-offset-1">

                <div class="pagin">
                    <webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages" CurrentPageButtonClass="cpb"
                        CustomInfoTextAlign="Left" HorizontalAlign="Right" PageIndexBoxType="TextBox"
                        ShowCustomInfoSection="Left" ShowMoreButtons="False" ShowNavigationToolTip="True"
                        ShowPageIndexBox="Always"
                        runat="server" AlwaysShow="True" PageSize="8" ShowInputBox="Always"
                        LayoutType="Table" OnPageChanging="AspNetPager1_PageChanging1"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
                        PagingButtonSpacing="2px" SubmitButtonClass="btngo">
                    </webdiyer:AspNetPager>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
