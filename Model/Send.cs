using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Send
    {
        public Guid Send_Id { set; get; } = Guid.NewGuid();
        public String Send_Image { set; get; }
        public String Send_Content { set; get; }
        public int Send_DeleteId { set; get; } = 1;
        public DateTime Send_CreateTime { set; get; } = DateTime.Now;
        public DateTime Send_UpdateTime { set; get; } = DateTime.Now;
    }
}
