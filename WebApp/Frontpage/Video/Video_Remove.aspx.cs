﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
namespace WebApp.Frontpage.Video
{
    public partial class Video_Romver : System.Web.UI.Page
    {
        VideoServices VideoSvc = new VideoServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            object ob = Session["LoginOk"];
            if (ob == null)
            {
                Response.Write("<script>alert('账号过期,请重新登入');location.href='../Login.aspx'</script>");
            }

            var id = Request.Params["action"];
            if (id != null)
            {
                Guid rid = Guid.Parse(id);
                var res = VideoSvc.PutTrash(rid);
                ReturnMsg rm = res > 0 ? new ReturnMsg()
                {
                    Code = StatusCode.OK,
                    Message = "删除用户信息成功",
                    Data = null
                }
                    : new ReturnMsg()
                    {
                        Code = StatusCode.Error,
                        Message = "删除用户信息失败",
                        Data = null
                    };
                Session["Msg"] = rm;
                Response.Redirect("Video_List.aspx");
            }
        }
    }
}