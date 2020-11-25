using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
namespace WebApp.Frontpage.Video
{
    public partial class Video_Edit : System.Web.UI.Page
    {
        VideoServices VideoSvc = new VideoServices();
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
            var data = VideoSvc.GetVideoById(id);
            if (data == null)
            {
                ReturnMsg rm = new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "数据丢失,请稍后再试",
                    Data = null
                };
                Session["msg"] = rm;
                Response.Redirect("Users_List.aspx");
            }

            this.hfId.Value = data.Video_Id.ToString();
            this.txtName.Text = data.Video_Title;
            this.txtIntro.Text = data.Video_Intro;
            this.textPath.Text = data.Video_Path;
            imgUrl = data.Video_Image;
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string photo = upFileName(this.FileUpload1, "../../upload/users/");
            Model.Video p = VideoSvc.GetVideoById(Guid.Parse(this.hfId.Value));
            if (photo == "")
            {
                p = new Model.Video
                {
                    Video_Title = this.txtName.Text,
                    Video_Intro = this.txtIntro.Text,
                    Video_Path = this.textPath.Text,
                    Video_UpdateTime = DateTime.Now
                };
            }
            else
            {
                p = new Model.Video
                {
                    Video_Title = this.txtName.Text,
                    Video_Intro = this.txtIntro.Text,
                    Video_Path = this.textPath.Text,
                    Video_Image = photo,
                    Video_UpdateTime = DateTime.Now
                };
            }

            var res = VideoSvc.Edit(p);
            ReturnMsg rm = res > 0
                ? new ReturnMsg()
                {
                    Code = StatusCode.OK,
                    Message = "编辑用户信息成功",
                    Data = null
                }
                : new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "编辑用户信息失败",
                    Data = null
                };

            Session["Msg"] = rm; //用于传递执行信息的
            Response.Redirect("Video_List.aspx");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Bind();
        }
        public string upFileName(FileUpload f, string url)
        {
            string res = "";
            Random ran = new Random();
            string filePath = f.FileName;
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + Convert.ToString(ran.Next(1, 1 + 9999));
            if (filePath != "")
            {
                string fileType = filePath.Substring(filePath.LastIndexOf(".") + 1);
                //string filePic = Server.MapPath(url + filePath);
                string filePic = Server.MapPath(url + fileName + "." + fileType);
                f.PostedFile.SaveAs(filePic);
                res = fileName + "." + fileType;
            }
            return res;
        }
    }
}