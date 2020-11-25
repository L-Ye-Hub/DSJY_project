using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Frontpage
{
    public partial class tuandui : System.Web.UI.Page
    {
        TeamServices teamSvc = new TeamServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }
        public void Bind()
        {
            var data = teamSvc.GetAll();
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            this.RepTeamList.DataSource = pds;
            this.RepTeamList.DataBind();
        }
    }
}