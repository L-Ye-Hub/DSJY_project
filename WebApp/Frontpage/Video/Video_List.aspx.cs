using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using BLL;
namespace WebApp.Frontpage.Video
{
    public partial class Video_List : System.Web.UI.Page
    {
        VideoServices VideoSvc = new VideoServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            Bind("");
        }
        public void Bind(string title)
        {
            var data = VideoSvc.GetVideoByTitle(title);
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1; //设置当前页面从第一页开始,下标为0
            pds.PageSize = AspNetPager1.PageSize;
            AspNetPager1.RecordCount = data.Count;
            this.RepUsersList.DataSource = pds;
            this.RepUsersList.DataBind();
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Bind(this.txtSearch.Text);
        }
        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            Bind(this.txtSearch.Text);
        }
    }
}