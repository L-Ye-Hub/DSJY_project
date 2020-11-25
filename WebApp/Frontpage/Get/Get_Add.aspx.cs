using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace WebApp.Frontpage.Get
{
    public partial class Get_Add : System.Web.UI.Page
    {
        GetServices getSvc = new GetServices();
        ProductServices productSvc = new ProductServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            var data = productSvc.GetAll();
            this.ddlProductId.DataSource = data;
            this.ddlProductId.DataTextField = "Product_Title";
            this.ddlProductId.DataValueField = "Product_Id";
            this.ddlProductId.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            Model.Get g = new Model.Get
            {
                Get_Site1 = this.txtSite1.Text,
                Get_Phone1 = this.txtPhone1.Text,
                Get_Site2 = this.txtSite2.Text,
                Get_Phone2 = this.txtPhone2.Text,
                Get_Site3 = this.txtSite3.Text,
                Get_Phone3 = this.txtPhone3.Text,
                Get_Image = upFileName(this.FileUpload1, "../../upload/Get/"),
                Get_ProductId = Guid.Parse(this.ddlProductId.SelectedValue)
            };
            var res = getSvc.Add(g);
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
            Response.Redirect("Get_List.aspx");

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtSite1.Text = this.txtPhone1.Text = "";
            this.ddlProductId.SelectedIndex = 0;
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