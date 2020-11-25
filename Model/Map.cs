using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Map
    {
        public Guid Map_Id { set; get; } = Guid.NewGuid();
        public String Map_Site { set; get; }
        public String Map_Phone { set; get; }
        public int Map_DeleteId { set; get; } = 1;
        public DateTime Map_CreateTime { set; get; } = DateTime.Now;
        public DateTime Map_UpdateTime { set; get; } = DateTime.Now;
    }
}
