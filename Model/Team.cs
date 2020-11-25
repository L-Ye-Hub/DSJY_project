using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Team
    {
        public Guid Team_Id { set; get; } = Guid.NewGuid();
        public String Team_Title { set; get; }
        public String Team_Image { set; get; }
        public String Team_Content { set; get; }
        public int Team_DeleteId { set; get; } = 1;
        public DateTime Team_CreateTime { set; get; } = DateTime.Now;
        public DateTime Team_UpdateTime { set; get; } = DateTime.Now;
    }
}
