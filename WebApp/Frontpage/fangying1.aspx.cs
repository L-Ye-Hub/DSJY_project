using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Frontpage
{
    public partial class fangying1 : System.Web.UI.Page
    {
        VideoServices videoSvc = new VideoServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }
        public void Bind()
        {
            var data = videoSvc.GetAll();

            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            this.RepVideoList.DataSource = pds;
            this.RepVideoList.DataBind();
        }
    }
}