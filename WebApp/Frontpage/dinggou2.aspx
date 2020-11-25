<%@ Page Title="" Language="C#" MasterPageFile="~/Frontpage/Shared/FrontShared.Master" AutoEventWireup="true" CodeBehind="dinggou2.aspx.cs" Inherits="WebApp.Frontpage.dinggou2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
    <script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
    <title>订购2</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bennera">
        <div class="benner_1a">
            <div class="benner_2a">
                <img src="assets/images1/tu37.jpg" />
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
            <div class="xia_1_2a">
                <ul>
                    <li>当前位置：</li>
                    <li><a href="#">首页</a> ></li>
                    <li><a href="#">业务体系</a> ></li>
                    <li><a href="#">在线订购</a> ></li>
                    <li class="li_6">&nbsp;赢鼎教育-高考报考定位卡
                    </li>
                </ul>
            </div>
        </div>
        <div class="jieshu">
            <img src="assets/images1/tu18.jpg" />
        </div>

        <div class="jieshu_1">
            <div class="dan">
                <div class="dan_1">
                    <div class="dan_1_1"><b>姓名：</b></div>
                    <div class="dan_1_2">
                        <label for="zxczc"></label>
                        <%--<input type="text" style="width: 208px; height: 32px; background: url(assets/images1/tu5.png) no-repeat; border: none;" />--%>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control " Style="width: 208px; height: 32px; background: url(assets/images1/tu5.png) no-repeat; border: none;"></asp:TextBox>
                    </div>
                    <div class="dan_1_3">
                        <img src="assets/images1/tu16.jpg" />
                    </div>
                    <div class="dan_1_4">请填写真实姓名，以便书正确送达。</div>
                </div>
                <div class="dan_1">
                    <div class="dan_1_1"><b>电话：</b></div>
                    <div class="dan_1_2">
                        <label for="zxczc"></label>
                        <%--<input type="text" style="width: 208px; height: 32px; background: url(assets/images1/tu5.png) no-repeat; border: none;" />--%>
                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control " Style="width: 208px; height: 32px; background: url(assets/images1/tu5.png) no-repeat; border: none;"></asp:TextBox>
                    </div>
                    <div class="dan_1_3">
                        <img src="assets/images1/tu16.jpg" />
                    </div>
                    <div class="dan_1_4">请填写真实联系方式。</div>
                </div>
                <div class="dan_2">
                    <div class="dan_2_1"><b>书名：</b></div>
                    <div class="dan_2_2">
                        <div class="dan_2_2a1">
                            <div class="dan_2_2_11">
                                <img src='../../upload/Product/<%=imgUrl %>' />
                            </div>
                        </div>
                        <div class="dan_2_2_2">
                            <asp:Label ID="txtTitle" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="dan_3">
                    <div class="dan_1_1"><b>费用：</b></div>
                    <div class="dan_1_3"><b>￥</b></div>
                    <div class="dan_3_2">
                        <b>
                            <asp:Label ID="txtPrice" runat="server" Text="Label"></asp:Label>
                        </b>
                    </div>
                    <div class="dan_3_3">元</div>
                </div>
                <div class="dan_1">
                    <div class="dan_1_1"><b>邮箱：</b></div>
                    <div class="dan_1_2">
                        <label for="zxczc"></label>
                        <%-- <input type="text" style="width: 208px; height: 32px; background: url(assets/images1/tu5.png) no-repeat; border: none;" />--%>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control " Style="width: 208px; height: 32px; background: url(assets/images1/tu5.png) no-repeat; border: none;"></asp:TextBox>
                    </div>
                    <div class="dan_1_3">
                        <img src="assets/images1/tu16.jpg" />
                    </div>
                </div>
                <div class="dan_1">
                    <div class="dan_1_1"><b>地址：</b></div>
                    <div class="dan_1_2">
                        <label for="zxczc"></label>
                        <%-- <input type="text" style="width: 208px; height: 32px; background: url(assets/images1/tu5.png) no-repeat; border: none;" />--%>
                        <asp:TextBox ID="txtSite" runat="server" CssClass="form-control " Style="width: 208px; height: 32px; background: url(assets/images1/tu5.png) no-repeat; border: none;"></asp:TextBox>
                    </div>
                    <div class="dan_1_3">
                        <img src="assets/images1/tu16.jpg" />
                    </div>
                    <div class="dan_1_8">请详细填写地址，如：沈阳市铁西区和谐大厦A座1205室。</div>
                </div>
                <br />
                <div class="dan_5">
                    <div class="dan_5_1">
                        <a href="#">
                            <%--<img src="assets/images1/tijiao.jpg" /></a></div>--%>
                            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="提交" CssClass="btn btn-primary" Style="width: 80px; height: 40px; color: azure; border: none;" BackColor="Orange" />
                    </div>
                </div>



                <div class="ye_1">
                    <div class="ye_1_1">
                        <a href="#">
                            <img src='../../upload/Hint/<%=HintTxt[0].Hint_Image %>' />
                        </a>
                    </div>
                    <div class="ye_1_2">
                        <div class="ye_1_2_1">
                            <h3><span><%=HintTxt[0].Hint_Phone %></span>温馨提示：<%=HintTxt[0].Hint_Title %></h3>
                            <h3 class="h3_1">请将支付的结果发图给我们，</h3>
                            <a href="#">&nbsp;&nbsp;QQ: <%=HintTxt[0].Hint_QQ %></a>
                        </div>
                        <div class="ye_2">
                            <a href="#">
                                <img src="assets/images1/tu15.jpg" />
                            </a>
                        </div>
                    </div>
                </div>
                <div class="kuai">
                    <div class="kuai_1">
                        <img src='../../upload/Get/<%=imgGet %>' />
                    </div>
                    <div class="kuai_2">
                        <div class="kuai_2_1">
                            <h2>地址：<asp:Label ID="txtSite1" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp
                                电话：<asp:Label ID="txtPhone1" runat="server" Text="Label"></asp:Label>
                            </h2>
                        </div>
                        <div class="kuai_2_1s">
                            <h2>地址：<asp:Label ID="txtSite2" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp
                                电话：<asp:Label ID="txtPhone2" runat="server" Text="Label"></asp:Label>
                            </h2>
                        </div>
                        <div class="kuai_2_1a">
                            <h2>地址：<asp:Label ID="txtSite3" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp
                               电话：<asp:Label ID="txtPhone3" runat="server" Text="Label"></asp:Label>
                            </h2>
                        </div>

                    </div>
                    <div class="clear"></div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
