using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace WebApp.Frontpage.Product
{
    public partial class ProductAdd : System.Web.UI.Page
    {
        ProductServices productSvc = new ProductServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Model.Product u = new Model.Product
            {
                Product_Title = this.txtName.Text,
                Product_Image = upFileName(this.FileUpload1, "../../upload/Product/"),
                Product_Intro = this.textIntro.Text,
                Product_Content = this.txtContent.Text,
                Product_Price = int.Parse(this.txtPrice.Text)
            };
            var res = productSvc.Add(u);
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
            Response.Redirect("Product_List.aspx");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtContent.Text = this.txtName.Text = this.txtPrice.Text = "";
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