using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
   public class NewsServices
    {
        NewsManager pm = new NewsManager();
        public int Add(News News)
        {
            return pm.Add(News);
        }

        public int Edit(News News)
        {
            return pm.Edit(News);
        }

        public int PutTrash(Guid id)
        {
            return pm.PutTrash(id);
        }
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

        public IList<News> GetAll()
        {
            return pm.GetAll();
        }

        public IList<News> GetNewsByTitle(string title)
        {
            return pm.GetNewsByTitle(title);
        }


        public News GetNewsById(Guid id)
        {
            return pm.GetNewsById(id);
        }

        public IList<News> GetAllInTrash()
        {
            return pm.GetAllInTrash();
        }

        public IList<News> GetNewsByTitleInTrash(string title)
        {
            return pm.GetNewsByTitleInTrash(title);
        }
    }
}
