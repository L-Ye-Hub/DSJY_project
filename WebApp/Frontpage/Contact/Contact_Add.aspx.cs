using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
namespace WebApp.Frontpage.ContactServices
{
    public partial class Contact_Add : System.Web.UI.Page
    {
        ContactService ContactSvc = new ContactService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Model.Contact u = new Model.Contact
            {
                Contact_Title1 = this.txtTitle1.Text.Trim(),
                Contact_Phone = this.txtPhone.Text.Trim(),
                Contact_Fax = this.txtFax.Text.Trim(),
                Contact_Email = this.txtEmail.Text.Trim(),
                Contact_Title2 = this.txtTitle2.Text.Trim(),
                Contact_Site = this.txtSite.Text.Trim(),
                Contact_Image1 = upFileName(this.FileUpload1, "../../upload/Contact/"),
                Contact_Image2 = upFileName(this.FileUpload2, "../../upload/Contact/"),
                Contact_Image3 = upFileName(this.FileUpload3, "../../upload/Contact/")
            };
            var res = ContactSvc.Add(u);
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
            Response.Redirect("Contact_List.aspx");
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtEmail.Text = this.txtFax.Text = this.txtPhone.Text = this.txtSite.Text = this.txtTitle1.Text = this.txtTitle2.Text = "";
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