<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="jieshu.aspx.cs" Inherits="WebApp.Frontpage.jieshu" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <title>借书</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                    <li class="li_6">&nbsp;免费借书</li>
                </ul>
            </div>
        </div>

        <asp:Repeater ID="RepBookList" runat="server">
            <ItemTemplate>
                <div class="jieshu">
                    <img src="assets/images1/u1.png" />
                </div>
                <div class="jieshu_1">
                    <div class="jieshu_2">
                        <div class="jieshu_2_1">
                            <a href="jieshu1.aspx?action=<%#Eval("Book_Id") %>">
                                <img src='../../upload/Book/<%#Eval("Book_Image") %>' /></a>
                        </div>
                        <div class="jieshu_2_2">
                            <h2><a href="jieshu1.aspx?action=<%#Eval("Book_Id") %>"><%#Eval("Book_Title") %></a></h2>
                            <h3>内容推荐：</h3>
                            <ul>
                                <li><%#Eval("Book_Content") %></li>
                            </ul>
                            <div class="jieshu_2_3">
                                <a href="jieshu1.aspx?action=<%#Eval("Book_Id") %>">
                                    <img src="assets/images1/tu3.png" /></a>
                            </div>
                        </div>
                    </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </div>
        <div class="row">
            <div class="col-md-10 col-md-offset-1">

                <div class="pagin">
                    <webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages" CurrentPageButtonClass="cpb"
                        CustomInfoTextAlign="Left" HorizontalAlign="Right" PageIndexBoxType="TextBox"
                        ShowCustomInfoSection="Left" ShowMoreButtons="False" ShowNavigationToolTip="True"
                        ShowPageIndexBox="Always"
                        runat="server" AlwaysShow="True" PageSize="8" ShowInputBox="Always"
                        LayoutType="Table" OnPageChanging="AspNetPager1_PageChanging"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
                        PagingButtonSpacing="2px" SubmitButtonClass="btngo">
                    </webdiyer:AspNetPager>
                </div>
            </div>
        </div>

</asp:Content>
