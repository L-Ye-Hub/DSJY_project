using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Frontpage
{
    public partial class wenhua : System.Web.UI.Page
    {
        CultureServices cultureSvc = new CultureServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }
        public void Bind()
        {
            var data = cultureSvc.GetAll();
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            this.RepcultureList.DataSource = pds;
            this.RepcultureList.DataBind();
        }
    }
}