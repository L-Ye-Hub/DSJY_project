using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public Guid Order_Id { set; get; } = Guid.NewGuid();
        public String Order_Name { set; get; }
        public String Order_Phone { set; get; }
        public String Order_Email { set; get; }
        public String Order_Site { set; get; }
        public Guid Order_relevance  { set; get; }
        public int Order_DeleteId { set; get; } = 1;
        public DateTime Order_CreateTime { set; get; } = DateTime.Now;
        public DateTime Order_UpdateTime { set; get; } = DateTime.Now;
    }
}
