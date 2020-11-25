<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Backend.Master" AutoEventWireup="true" CodeBehind="Intro_List.aspx.cs" Inherits="WebApp.Frontpage.Intro.Intro_List" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       <div class="row mb-1">
        <div class="col-md-10 col-md-offset-1">

            <div class="col-md-5">
                <%--<input type="text" class="form-control"/>--%>
                <asp:TextBox ID="txtSearch" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <%--<button class="btn btn-primary">Go</button>--%>
                <asp:Button ID="btnSearch" runat="server" Text="Go" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                <a href="Intro_Add.aspx" class="btn btn-success">Insert</a>
                <button class="btn btn-danger">Delete</button>
            </div>

        </div>
    </div>

    <div class="row">
        <div class="col-md-10 col-md-offset-1">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">产品表</h3>
                </div>
                <div class="panel-body">
                    <table class="table table-bordered table-hover">
                        <thead>
                            <tr>
                               <th width="5%">赢鼎简介编号</th>  
                                <th width="10%">赢鼎简介图片</th>
                                <th width="10%">赢鼎简介内容</th>
                                <th width="5%">编辑</th>
                                <th width="5%">删除</th>

                            </tr>

                        </thead>
                        <tbody>
                            <asp:Repeater ID="RepUsersList" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Container.ItemIndex+1 %></td>                               
                                        <td>
                                            <img src='../../upload/Intro/<%#Eval("Intro_Image ") %>' style="width: 100px; height: 100px;" />
                                        </td>
                                        <td>
                                            <%#Eval("Intro_Content") %>
                                        </td>
                                        
                                        <td>
                                            <a class="btn btn-warning" href='Intro_Edit.aspx?action=<%#Eval("Intro_Id") %>'>
                                                <span class="lnr lnr-pencil"></span>修改
                                        </a>
                                        </td>
                                        <td>
                                            <a class="btn btn-danger" href='Intro_Remove.aspx?action=<%#Eval("Intro_Id") %>'>
                                                <span class="lnr lnr-trash"></span>删除
                                        </a>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </tbody>

                    </table>
                </div>
            </div>
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
