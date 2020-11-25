using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Get
    {
        public Guid Get_Id { set; get; } = Guid.NewGuid();
        public String Get_Image { set; get; }
        public String Get_Site1 { set; get; }
        public String Get_Phone1 { set; get; }
        public String Get_Site2 { set; get; }
        public String Get_Phone2 { set; get; }
        public String Get_Site3 { set; get; }
        public String Get_Phone3 { set; get; }
        public Guid Get_ProductId { set; get; }
        public int Get_DeleteId { set; get; } = 1;
        public DateTime Get_CreateTime { set; get; } = DateTime.Now;
        public DateTime Get_UpdateTime { set; get; } = DateTime.Now;
}
}
