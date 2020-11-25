using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
  public   class ContactService
    {
        ContactManagercs pm = new ContactManagercs();
        public int Add(Contact Contact)
        {
            return pm.Add(Contact);
        }

        public int Edit(Contact Contact)
        {
            return pm.Edit(Contact);
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
 

        public int Delete(Guid id)
        {
            return pm.Delete(id);
        }

        public IList<Contact> GetAll()
        {
            return pm.GetAll();
        }

        public IList<Contact> GetContactByTitle(string title)
        {
            return pm.GetContactByTitle(title);
        }


        public Contact GetContactById(Guid id)
        {
            return pm.GetContactById(id);
        }

        public IList<Contact> GetAllInTrash()
        {
            return pm.GetAllInTrash();
        }

        public IList<Contact> GetContactByTitleInTrash(string title)
        {
            return pm.GetContactByTitleInTrash(title);
        }
    }
}
