using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class AboutService
    {
        private readonly AboutManager dal = new AboutManager();

        public int Add(About model)
        {
            return dal.Add(model);
        }

        public int Edit(About model)
        {
            return dal.Edit(model);
        }


        public About GetAll()
        {
            return dal.GetAll();
        }
    }
}
