<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Backend.Master" AutoEventWireup="true" CodeBehind="Get_Add.aspx.cs" Inherits="WebApp.Frontpage.Get.Get_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>新增用户</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">新增领取地址</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>领取地址1:</label>
                        <asp:TextBox ID="txtSite1" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>领取电话1:</label>
                        <asp:TextBox ID="txtPhone1" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>领取地址2:</label>
                        <asp:TextBox ID="txtSite2" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>领取电话2:</label>
                        <asp:TextBox ID="txtPhone2" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>领取地址3:</label>
                        <asp:TextBox ID="txtSite3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>领取电话3:</label>
                        <asp:TextBox ID="txtPhone3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>相关产品:</label>
                        <asp:DropDownList ID="ddlProductId" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>领取图标:</label>
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="保存" CssClass="btn btn-primary" />
                        <asp:Button ID="btnReset" OnClick="btnReset_Click" runat="server" Text="重置" CssClass="btn btn-danger" />
                    </div>
                </div>
            </div>
            

        </div>
    </div>
</asp:Content>
