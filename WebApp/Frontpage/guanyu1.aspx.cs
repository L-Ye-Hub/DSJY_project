using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Frontpage
{
    public partial class guanyu1 : System.Web.UI.Page
    {
        IntroServices introSvc = new IntroServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }
        public void Bind()
        {
            var data = introSvc.GetAll();
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            this.RepIntroList.DataSource = pds;
            this.RepIntroList.DataBind();
        }
    }
}