using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hint
    {
        public Guid Hint_Id { set; get; } = Guid.NewGuid();
        public String Hint_Title { set; get; }
        public String Hint_Phone { set; get; }
        public String Hint_Image { set; get; }
        public String Hint_QQ { set; get; }
        public int Hint_DeleteId { set; get; } = 1;
        public DateTime Hint_CreateTime { set; get; } = DateTime.Now;
        public DateTime Hint_UpdateTime { set; get; } = DateTime.Now;
    }
}
