using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace WebApp
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly UsersService usersSvc = new UsersService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var data = usersSvc.Login(this.txtEmail.Text, MD5Helper.Md5(this.txtPwd.Text));
            if (data != null)
            {
                Session["LoginOk"] = data;
                Response.Write("<script>location.href='Admins/Welcome/Welcome.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('账号或者密码错误,请重新输入');</script>");
            }
        }
    }
}