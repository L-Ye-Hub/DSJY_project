using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
namespace WebApp.Frontpage.Culture
{
    public partial class Culture_Add : System.Web.UI.Page
    {
        CultureServices CultureSvc = new CultureServices();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Model.Culture u = new Model.Culture
            {
                Culture_Intro = this.txtIntro.Text.Trim(),
                Culture_Title1 = this.txtTitle1.Text,
                Culture_content1 = this.txtcontent1.Text,
                Culture_Title2 = this.txtTitle2.Text,
                Culture_content2 = this.txtcontent2.Text,
                Culture_Title3 = this.txtTitle3.Text,
                Culture_content3 = this.txtcontent3.Text,
                Culture_Title4 = this.txtTitle4.Text,
                Culture_content4 = this.txtcontent4.Text,
                Culture_Title5 = this.txtTitle5.Text,
                Culture_content5 = this.txtcontent5.Text,
            };
            var res = CultureSvc.Add(u);
            ReturnMsg rm = res > 0
                ? new ReturnMsg()
                {
                    Code = StatusCode.OK,
                    Message = "新增用户信息成功",
                    Data = null
                }
                : new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "新增用户信息失败",
                    Data = null
                };

            Session["Msg"] = rm; //用于传递执行信息的
            Response.Redirect("Culture_List.aspx");
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtIntro.Text = this.txtTitle1.Text = "";
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