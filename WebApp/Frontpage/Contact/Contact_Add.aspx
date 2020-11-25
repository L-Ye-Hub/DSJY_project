<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Backend.Master" AutoEventWireup="true" CodeBehind="Contact_Add.aspx.cs" Inherits="WebApp.Frontpage.ContactServices.Contact_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">请输入你要新增的信息 </h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>联系标题:</label>
                        <asp:TextBox ID="txtTitle1" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>联系电话:</label>
                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
                    
                    </div>
                    <div class="form-group">
                        <label>联系传真:</label>
                        <asp:TextBox ID="txtFax" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>联系邮箱:</label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                     <div class="form-group">
                        <label>联系标题2:</label>
                        <asp:TextBox ID="txtTitle2" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                     <div class="form-group">
                        <label>联系地址:</label>
                        <asp:TextBox ID="txtSite" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                     <div class="form-group">
                        <label>联系图片1:</label>
                           <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                    </div>
                     <div class="form-group">
                        <label>联系图片2:</label>
                         <asp:FileUpload ID="FileUpload2" runat="server" CssClass="form-control" />
                    </div>
                     <div class="form-group">
                        <label>联系图片3:</label>
                            <asp:FileUpload ID="FileUpload3" runat="server" CssClass="form-control" />
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
