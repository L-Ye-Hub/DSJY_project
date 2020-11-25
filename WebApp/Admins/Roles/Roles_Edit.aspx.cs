using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace WebApp.Admins.Roles
{
    public partial class Roles_Edit : System.Web.UI.Page
    {
        RolesService rolesSvc = new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
                Bind();
        }
        public void Bind()
        {
            var gid = Request.Params["action"] == null ? Guid.NewGuid() : Guid.Parse(Request.Params["action"]);
            var data = rolesSvc.GetRolesById(gid);
            if (data == null)
            {
                Response.Write("<script>alert('网络较差,请稍后再试');location.href='Roles_List.aspx'</script>");
            }
            else
            {
                this.txtId.Text = data.Roles_Id.ToString();
                this.txtName.Text = data.Roles_Title;
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var res = rolesSvc.Edit(new Model.Roles()
            {
                Roles_Id = Guid.Parse(this.txtId.Text),
                Roles_Title = this.txtName.Text,
                Roles_UpdateTime = DateTime.Now
            });
            ReturnMsg rm = res > 0
                ? new ReturnMsg()
                {
                    Code = StatusCode.OK,
                    Message = "修改权限成功",
                    Data = null
                }
                : new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "修改权限失败",
                    Data = null
                };
            Session["Msg"] = rm;
            Response.Redirect("Roles_List.aspx");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Bind();
        }
    }
}