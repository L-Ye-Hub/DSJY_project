using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
   public  class SendServices
    {
        SendManager pm = new SendManager();
        public int Add(Send Send)
        {
            return pm.Add(Send);
        }

        public int Edit(Send Send)
        {
            return pm.Edit(Send);
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

        public IList<Send> GetAll()
        {
            return pm.GetAll();
        }

        public IList<Send> GetSendByTitle(string title)
        {
            return pm.GetSendByTitle(title);
        }


        public Send GetSendById(Guid id)
        {
            return pm.GetSendById(id);
        }

        public IList<Send> GetAllInTrash()
        {
            return pm.GetAllInTrash();
        }

        public IList<Send> GetSendByTitleInTrash(string title)
        {
            return pm.GetSendByTitleInTrash(title);
        }
    }
}
