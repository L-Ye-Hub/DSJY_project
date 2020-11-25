using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Frontpage.Order
{
    public partial class Order_List : System.Web.UI.Page
    {
        OrderServices orderSvc = new OrderServices();
        ProductServices productSvc = new ProductServices();
        String table = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            Bind("");
        }
        public void Bind(string Name)
        {
            var data = orderSvc.GetOrderByName(Name);
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1; //设置当前页面从第一页开始,下标为0
            pds.PageSize = AspNetPager1.PageSize;
            AspNetPager1.RecordCount = data.Count;
            this.RepUsersList.DataSource = pds;
            this.RepUsersList.DataBind();
        }
        public string GetrelevanName(Guid id)
        {
            if (table == "Product")
            {
                return productSvc.GetProductById(id).Product_Title;
            }
            else if(table == "Book"){ 
                return productSvc.GetProductById(id).Product_Title;
            }else {
                return null;
            }
            
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {

        }
    }
}