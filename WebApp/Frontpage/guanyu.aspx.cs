using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Frontpage
{
    public partial class guanyu : System.Web.UI.Page
    {
        SendServices sendSvc = new SendServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }
        public void Bind()
        {
            var data = sendSvc.GetAll();
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            this.RepSendList.DataSource = pds;
            this.RepSendList.DataBind();
        }
    }
}