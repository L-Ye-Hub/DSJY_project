using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class News
    {
        public Guid News_Id { set; get; } = Guid.NewGuid();
        public String News_Title { set; get; }
        public String News_Image { set; get; }
        public String News_Intro { set; get; }
        public String News_Content { set; get; }
        public int News_DeleteId { set; get; } = 1;
        public DateTime News_CreateTime { set; get; } = DateTime.Now;
        public DateTime News_UpdateTime { set; get; } = DateTime.Now;
    }
}
