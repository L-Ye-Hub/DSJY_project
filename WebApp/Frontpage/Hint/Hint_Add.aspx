<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Backend.Master" AutoEventWireup="true" CodeBehind="Hint_Add.aspx.cs" Inherits="WebApp.Frontpage.Hint.Hint_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">请输入你要新增的温馨提示</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>温馨提示信息:</label>
                        <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>                   
                    <div class="form-group">
                        <label>温馨提示手机号:</label>
                        <asp:TextBox ID="textPhone" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                     <div class="form-group">
                        <label>温馨提示图片:</label>
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label>温馨提示QQ:</label>
                        <asp:TextBox ID="txtQQ" runat="server" CssClass="form-control"></asp:TextBox>
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
