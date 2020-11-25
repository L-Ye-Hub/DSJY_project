using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Frontpage
{
    public partial class index : System.Web.UI.Page
    {
        VideoServices videoSvc = new VideoServices();
        NewsServices newsSvc = new NewsServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            getVideo();
            getNews();
        }
        public IList<Model.News> Newstxt = null;
        public void getNews()
        {
            var news = newsSvc.GetAll();
            Newstxt = news;
        }
        public IList<Model.Video> Videotxt = null;
        public void getVideo()
        {
            var video = videoSvc.GetAll();
            Videotxt = video;
        }
    }
}