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
    public partial class dinggou1 : System.Web.UI.Page
    {
        ProductServices productSvc = new ProductServices();
        public string imgProduct = "";
        public string ProductId = "";
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
                Response.Redirect("dinggou1.aspx?action=" + Request.Params["action"] + "");
            }
            this.txtTitle.Text = data.Product_Title;
            this.txtPrice.Text = data.Product_Price.ToString() ;
            this.txtContent.Text = data.Product_Content;
            imgProduct = data.Product_Image;
            ProductId = data.Product_Id.ToString();
        }
    }
}