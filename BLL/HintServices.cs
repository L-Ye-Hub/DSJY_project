using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class HintServices
    {
        HintManager hm = new HintManager(); 
        public int Add(Hint hint)
        {
            return hm.Add(hint);
        }

        public int Edit(Hint hint)
        {
            return hm.Edit(hint);
        }

        public int PutTrash(Guid id)
        {
            return hm.PutTrash(id);
        }

        public int Restore(Guid id)
        {
            return hm.Restore(id);
        }

        public int Delete(Guid id)
        {
            return hm.Delete(id);
        }

        public IList<Hint> GetAll()
        {
            return hm.GetAll();
        }

        public IList<Hint> GetHintByTitle(string title)
        {
            return hm.GetHintByTitle(title);
        }

        public Hint GetHintById(Guid id)
        {
            return hm.GetHintById(id);
        }


        public IList<Hint> GetAllInTrash()
        {
            return hm.GetAllInTrash();
        }

        public IList<Hint> GetHintByTitleInTrash(string title)
        {
            return hm.GetHintByTitleInTrash(title);
        }
    }
}
