using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public Guid Product_Id { get; set; } = Guid.NewGuid();
        public String Product_Title { get; set; }
        public String Product_Image { get; set; }
        public String Product_Intro { get; set; }
        public String Product_Content { get; set; }
        public double Product_Price { get; set; }
        public int Product_DeleteId { get; set; } = 1;
        public DateTime Product_CreateTime { get; set; } = DateTime.Now;
        public DateTime Product_UpdateTime { get; set; } = DateTime.Now;
    }
}
