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
    public partial class Product_Edit : System.Web.UI.Page
    {
        ProductServices productSvc = new ProductServices();
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
            var data = productSvc.GetProductById(id);
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

            this.hfId.Value = data.Product_Id.ToString();
            this.txtName.Text = data.Product_Title;
            this.textIntro.Text = data.Product_Intro;
            this.txtContent.Text = data.Product_Content;
            this.txtPrice.Text = data.Product_Price.ToString();
            imgUrl = data.Product_Image;
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string photo = upFileName(this.FileUpload1, "../../upload/users/");
            Model.Product p = productSvc.GetProductById(Guid.Parse(this.hfId.Value));
            if (photo == "")
            {
                p = new Model.Product
                {
                    Product_Title = this.txtName.Text,
                    Product_Intro = this.textIntro.Text,
                    Product_Content = this.txtContent.Text,
                    Product_Price = double.Parse(this.txtPrice.Text),
                    Product_UpdateTime = DateTime.Now
                };
            }
            else
            {
                p = new Model.Product
                {
                    Product_Title = this.txtName.Text,
                    Product_Intro = this.textIntro.Text,
                    Product_Content = this.txtContent.Text,
                    Product_Price = double.Parse(this.txtPrice.Text),
                    Product_Image = photo,
                    Product_UpdateTime = DateTime.Now
                };
            }

            var res = productSvc.Edit(p);
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
            Response.Redirect("Product_List.aspx");
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