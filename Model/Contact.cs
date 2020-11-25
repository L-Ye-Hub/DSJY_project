using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        public Guid Contact_Id { set; get; } = Guid.NewGuid();
        public String Contact_Title1 { set; get; }
        public String Contact_Phone { set; get; }
        public String Contact_Fax { set; get; }
        public String Contact_Email { set; get; }
        public String Contact_Title2 { set; get; }
        public String Contact_Site { set; get; }
        public String Contact_Image1 { set; get; }
        public String Contact_Image2 { set; get; }
        public String Contact_Image3 { set; get; }
        public int Contact_DeleteId { set; get; } = 1;
        public DateTime Contact_CreateTime { set; get; } = DateTime.Now;
        public DateTime Contact_UpdateTime { set; get; } = DateTime.Now;
    }
}
