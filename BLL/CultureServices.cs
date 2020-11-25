using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
   public class CultureServices
    {
        CultureManager pm = new CultureManager();
        public int Add(Culture Culture)
        {
            return pm.Add(Culture);
        }

        public int Edit(Culture Culture)
        {
            return pm.Edit(Culture);
        }

        public int PutTrash(Guid id)
        {
            return pm.PutTrash(id);
        }
        /// <summary>
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            return pm.Restore(id);
        }

        public int Delete(Guid id)
        {
            return pm.Delete(id);
        }

        public IList<Culture> GetAll()
        {
            return pm.GetAll();
        }

        public IList<Culture> GetCultureByTitle(string title)
        {
            return pm.GetCultureByTitle(title);
        }


        public Culture GetCultureById(Guid id)
        {
            return pm.GetCultureById(id);
        }

        public IList<Culture> GetAllInTrash()
        {
            return pm.GetAllInTrash();
        }

        public IList<Culture> GetCultureByTitleInTrash(string title)
        {
            return pm.GetCultureByTitleInTrash(title);
        }
    }
}
