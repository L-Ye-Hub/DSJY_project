using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Intro
    {

        public Guid Intro_Id { set; get; } = Guid.NewGuid();
        public String Intro_Image { set; get; }
        public String Intro_Content { set; get; }
        public int Intro_DeleteId { set; get; } = 1;
        public DateTime Intro_CreateTime { set; get; } = DateTime.Now;
        public DateTime Intro_UpdateTime { set; get; } = DateTime.Now;
    }
}
