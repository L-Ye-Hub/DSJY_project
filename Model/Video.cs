using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Video
    {
        public Guid Video_Id { set; get; } = Guid.NewGuid();
        public String Video_Title { set; get; }
        public String Video_Intro { set; get; }
        public String Video_Path { set; get; }
        public String Video_Image { set; get; }
        public int Video_DeleteId { set; get; } = 1;
        public DateTime Video_CreateTime { set; get; } = DateTime.Now;
        public DateTime Video_UpdateTime { set; get; } = DateTime.Now;
    }
}
