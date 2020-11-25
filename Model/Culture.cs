using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Culture
    {
        public Guid Culture_Id { set; get; } = Guid.NewGuid();
        public String Culture_Intro { set; get; }
        public String Culture_Title1 { set; get; }
        public String Culture_content1 { set; get; }
        public String Culture_Title2 { set; get; }
        public String Culture_content2 { set; get; }
        public String Culture_Title3 { set; get; }
        public String Culture_content3 { set; get; }
        public String Culture_Title4 { set; get; }
        public String Culture_content4 { set; get; }
        public String Culture_Title5 { set; get; }
        public String Culture_content5 { set; get; }
        public int Culture_DeleteId { set; get; } = 1;
        public DateTime Culture_CreateTime { set; get; } = DateTime.Now;
        public DateTime Culture_UpdateTime { set; get; } = DateTime.Now;
    }
}
