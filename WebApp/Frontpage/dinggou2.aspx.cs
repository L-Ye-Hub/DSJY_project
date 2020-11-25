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
    public partial class dinggou2 : System.Web.UI.Page
    {
        ProductServices productSvc = new ProductServices();
        HintServices hintSvc = new HintServices();
        GetServices getSvc = new GetServices();
        public string imgUrl = "";
        public string imgGet = "";
        public string imgHint = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            getProduct();
            getHint();
            getGet();
        }
        public void getProduct()
        {
            var id = Request.Params["action"] == null ? Guid.NewGuid() : Guid.Parse(Request.Params["action"]);
            var product = productSvc.GetProductById(id);
            if (product == null)
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
            this.txtPrice.Text = product.Product_Price.ToString();
            this.txtTitle.Text = product.Product_Title;
            imgUrl = product.Product_Image;
        }

        public IList<Model.Hint> HintTxt = null;
        public void getHint()
        {
            var hint = hintSvc.GetAll();
            
            if (hint == null)
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
            else
            {
                HintTxt = hint;
            }


        }

        public void getGet()
        {
            var id = Request.Params["action"] == null ? Guid.NewGuid() : Guid.Parse(Request.Params["action"]);
            var get = getSvc.GetGetByProductId(id);
            if (get == null)
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
            this.txtSite1.Text = get.Get_Site1;
            this.txtSite2.Text = get.Get_Site2;
            this.txtSite3.Text = get.Get_Site3;
            this.txtPhone1.Text = get.Get_Phone1;
            this.txtPhone2.Text = get.Get_Phone2;
            this.txtPhone3.Text = get.Get_Phone3;
            imgGet = get.Get_Image;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}