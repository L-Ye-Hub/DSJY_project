using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        public Guid Book_Id { set; get; } = Guid.NewGuid();
        public String Book_Title { set; get; }
        public String Book_Content { set; get; }
        public String Book_Image { set; get; }
        public double Book_Price { set; get; }
        public String Book_publish { set; get; }
        public String Book_Author { set; get; }
        public String Book_Intro { set; get; }
        public String Book_Catalog { set; get; }
        public String  Book_Read  { set; get; }
        public int Book_DeleteId { set; get; } = 1;
        public DateTime Book_CreateTime { set; get; } = DateTime.Now;
        public DateTime Book_UpdateTime { set; get; } = DateTime.Now;
    }
}
