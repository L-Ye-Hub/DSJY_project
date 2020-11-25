using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Frontpage
{
    public partial class dinggou : System.Web.UI.Page
    {
        ProductServices productSvc = new ProductServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            Bind();
        }
        public void Bind()
        {
            var list = productSvc.GetAll();

            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = list;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1; //设置当前页面从第一页开始,下标为0
            pds.PageSize = AspNetPager1.PageSize;
            AspNetPager1.RecordCount = list.Count;

            this.RepRolesList.DataSource = pds;
            this.RepRolesList.DataBind();
        }

        protected void AspNetPager1_PageChanging1(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            Bind();
        }
    }
}