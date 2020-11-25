<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Backend.Master" AutoEventWireup="true" CodeBehind="Culture_Add.aspx.cs" Inherits="WebApp.Frontpage.Culture.Culture_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">请输入你要新增的文化</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>文化简介:</label>
                        <asp:TextBox ID="txtIntro" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化标题1:</label>
                         <asp:TextBox ID="txtTitle1" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化内容1:</label>
                        <asp:TextBox ID="txtcontent1" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化标题2:</label>
                         <asp:TextBox ID="txtTitle2" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化内容2:</label>
                        <asp:TextBox ID="txtcontent2" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化标题3:</label>
                         <asp:TextBox ID="txtTitle3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化内容3:</label>
                        <asp:TextBox ID="txtcontent3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化标题4:</label>
                         <asp:TextBox ID="txtTitle4" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化内容4:</label>
                        <asp:TextBox ID="txtcontent4" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化标题5:</label>
                         <asp:TextBox ID="txtTitle5" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>文化内容5:</label>
                        <asp:TextBox ID="txtcontent5" runat="server" CssClass="form-control"></asp:TextBox>
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
