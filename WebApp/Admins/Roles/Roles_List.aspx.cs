using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Admins.Roles
{
    public partial class Roles_List : System.Web.UI.Page
    {
        private readonly RolesService rolesSvc = new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            Bind("");
        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            Bind(this.txtSearch.Text);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Bind(this.txtSearch.Text);
        }
        public void Bind(string title)
        {
            var list = rolesSvc.GetRolesByTitle(title);

            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = list;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1; //设置当前页面从第一页开始,下标为0
            pds.PageSize = AspNetPager1.PageSize;
            AspNetPager1.RecordCount = list.Count;

            this.RepRolesList.DataSource = pds;
            this.RepRolesList.DataBind();
        }
    }
}