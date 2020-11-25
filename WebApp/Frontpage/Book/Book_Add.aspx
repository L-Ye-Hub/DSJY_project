<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Backend.Master" AutoEventWireup="true" CodeBehind="Book_Add.aspx.cs" Inherits="WebApp.Frontpage.Book.Book_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">请输入你要新增的书</h3>
                </div>
                <div class="panel-body">     
                    <div class="form-group">
                        <label>书名:</label>
                        <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>内容推荐:</label>
                        <asp:TextBox ID="txtContent" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>书图片路径:</label>
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label>借阅金额:</label>
                        <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
                    </div><div class="form-group">
                        <label>出版:</label>
                        <asp:TextBox ID="txtpublish" runat="server" CssClass="form-control"></asp:TextBox>
                    </div><div class="form-group">
                        <label>作者:</label>
                        <asp:TextBox ID="txtAuthor" runat="server" CssClass="form-control"></asp:TextBox>
                    </div><div class="form-group">
                        <label>简介:</label>
                        <asp:TextBox ID="txtIntro" runat="server" CssClass="form-control"></asp:TextBox>
                    </div><div class="form-group">
                        <label>目录:</label>
                        <asp:TextBox ID="txtCatalog" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>在线阅读:</label>
                        <asp:TextBox ID="txtRead" runat="server" CssClass="form-control"></asp:TextBox>
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
