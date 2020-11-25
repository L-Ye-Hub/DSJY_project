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
    public partial class jieshu1 : System.Web.UI.Page
    {
        BookServices bookSvc = new BookServices();
        HintServices hintSvc = new HintServices();
        public string imgUrl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
            getHint();
        }
        public void Bind()
        {
            var id = Request.Params["action"] == null ? Guid.NewGuid() : Guid.Parse(Request.Params["action"]);
            var data = bookSvc.GetBookById(id);
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
            this.txtPrice.Text = data.Book_Price.ToString();
            this.txtTitle.Text = data.Book_Title;
            imgUrl = data.Book_Image;
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}