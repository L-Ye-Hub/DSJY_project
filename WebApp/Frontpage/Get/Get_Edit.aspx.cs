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
    public partial class Get_Edit : System.Web.UI.Page
    {
        GetServices getSvc = new GetServices();
        ProductServices productSvc = new ProductServices();
        public string imgUrl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            var data = productSvc.GetAll();
            this.ddlProductId.DataSource = data;
            this.ddlProductId.DataTextField = "Product_Title";
            this.ddlProductId.DataValueField = "Product_Id";
            this.ddlProductId.DataBind();
            Bind();
        }
        public void Bind()
        {
            var id = Request.Params["action"] == null ? Guid.NewGuid() : Guid.Parse(Request.Params["action"]);
            var data = getSvc.GetGetById(id);
            if (data == null)
            {
                ReturnMsg rm = new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "数据丢失,请稍后再试",
                    Data = null
                };
                Session["msg"] = rm;
                Response.Redirect("Get_List.aspx");
            }
            this.hfId.Value = data.Get_Id.ToString();
            this.txtSite1.Text = data.Get_Site1;
            this.txtPhone1.Text = data.Get_Phone1;
            this.txtSite2.Text = data.Get_Site2;
            this.txtPhone2.Text = data.Get_Phone2;
            this.txtSite3.Text = data.Get_Site3;
            this.txtPhone3.Text = data.Get_Phone3;
            imgUrl = data.Get_Image;
            this.ddlProductId.SelectedValue = data.Get_ProductId.ToString();
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string photo = upFileName(this.FileUpload1, "../../upload/Get/");
            Model.Get u = getSvc.GetGetById(Guid.Parse(this.hfId.Value));
            if (photo == "")
            {
                u.Get_Site1 = this.txtSite1.Text;
                u.Get_Phone1 = this.txtPhone1.Text;
                u.Get_Site2 = this.txtSite2.Text;
                u.Get_Phone2 = this.txtPhone2.Text;
                u.Get_Site3 = this.txtSite3.Text;
                u.Get_Phone3 = this.txtPhone3.Text;
                u.Get_ProductId = Guid.Parse(this.ddlProductId.SelectedValue);
                u.Get_UpdateTime = DateTime.Now;
            }
            else
            {
                u.Get_Site1 = this.txtSite1.Text;
                u.Get_Phone1 = this.txtPhone1.Text;
                u.Get_Site2 = this.txtSite2.Text;
                u.Get_Phone2 = this.txtPhone2.Text;
                u.Get_Site3 = this.txtSite3.Text;
                u.Get_Phone3 = this.txtPhone3.Text;
                u.Get_Image = photo;
                u.Get_ProductId = Guid.Parse(this.ddlProductId.SelectedValue);
                u.Get_UpdateTime = DateTime.Now;
            }

            var res = getSvc.Edit(u);
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
            Response.Redirect("Get_List.aspx");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

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