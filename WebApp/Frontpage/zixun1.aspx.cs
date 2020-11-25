using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace WebApp.Frontpage
{
    public partial class zixun1 : System.Web.UI.Page
    {
        NewsServices newsSvc = new NewsServices();
        public string imgUrl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }
        public void Bind()
        {
            var id = Request.Params["action"] == null ? Guid.NewGuid() : Guid.Parse(Request.Params["action"]);
            var data = newsSvc.GetNewsById(id);
            if (data == null)
            {
                ReturnMsg rm = new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "数据丢失,请稍后再试",
                    Data = null
                };
                Session["msg"] = rm;
                Response.Redirect("zixun.aspx");
            }
            this.txtTitle.Text = data.News_Title;
            this.txtTime.Text = data.News_CreateTime.ToString();
            this.txtIntro.Text = data.News_Intro;
            this.txtContent.Text = data.News_Content;
            imgUrl = data.News_Image;
        }
    }
}