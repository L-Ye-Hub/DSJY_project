using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace WebApp.Frontpage
{
    public partial class zixun : System.Web.UI.Page
    {
        NewsServices newsSvc = new NewsServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }

        public void Bind()
        {
            var data = newsSvc.GetAll();
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            this.RepNewsList.DataSource = pds;
            this.RepNewsList.DataBind();
        }

    }
}