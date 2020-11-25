using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
   public  class IntroServices
    {
        IntroManager pm = new IntroManager();
        public int Add(Intro Intro)
        {
            return pm.Add(Intro);
        }

        public int Edit(Intro Intro)
        {
            return pm.Edit(Intro);
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

        public IList<Intro> GetAll()
        {
            return pm.GetAll();
        }

        public IList<Intro> GetIntroByTitle(string title)
        {
            return pm.GetIntroByTitle(title);
        }


        public Intro GetIntroById(Guid id)
        {
            return pm.GetIntroById(id);
        }

        public IList<Intro> GetAllInTrash()
        {
            return pm.GetAllInTrash();
        }

        public IList<Intro> GetIntroByTitleInTrash(string title)
        {
            return pm.GetIntroByTitleInTrash(title);
        }
    }
}
