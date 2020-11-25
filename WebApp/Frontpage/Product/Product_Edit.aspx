<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Backend.Master" AutoEventWireup="true" CodeBehind="Product_Edit.aspx.cs" Inherits="WebApp.Frontpage.Product.Product_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>编辑产品</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">新增产品</h3>
                </div>
                <div class="panel-body">
                    <asp:HiddenField ID="hfId" runat="server"  />
                    <div class="form-group">
                        <label>产品名称:</label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>产品图片:</label>
                        <img src="../../upload/users/<%=imgUrl %>"/>
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label>产品简介:</label>
                        <asp:TextBox ID="textIntro" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>产品内容:</label>
                        <asp:TextBox ID="txtContent" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>产品价格:</label>
                        <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
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
