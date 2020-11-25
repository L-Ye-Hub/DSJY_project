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
    public partial class fangying : System.Web.UI.Page
    {
        VideoServices videoSvc = new VideoServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }
        public void Bind() 
        {
            var id = Request.Params["action"] == null ? Guid.NewGuid() : Guid.Parse(Request.Params["action"]);
            var data = videoSvc.GetVideoFrontPageById(id);
            if (data == null)
            {
                ReturnMsg rm = new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "数据丢失,请稍后再试",
                    Data = null
                };
                Session["msg"] = rm;
                Response.Redirect("fangying1.aspx");
            }
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            this.RepVideoList.DataSource = pds;
            this.RepVideoList.DataBind();
        }
        
    }
}