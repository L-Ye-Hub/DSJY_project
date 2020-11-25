using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class GetServices
    {
        GetManager gm = new GetManager();
        public int Add(Get Get)
        {
            return gm.Add(Get);
        }

        public int Edit(Get Get)
        {
            return gm.Edit(Get);
        }

        public int PutTrash(Guid id)
        {
            return gm.PutTrash(id);
        }

        public int Restore(Guid id)
        {
            return gm.Restore(id);
        }

        public int Delete(Guid id)
        {
            return gm.Delete(id);
        }

        public IList<Get> GetAll()
        {
            return gm.GetAll();
        }

        public IList<Get> GetGetBySite(string site)
        {
            return gm.GetGetBySite(site);
        }

        public Get GetGetById(Guid id)
        {
            return gm.GetGetById(id);
        }

        public Get GetGetByProductId(Guid id)
        {
            return gm.GetGetByProductId(id);
        }

        public IList<Get> GetAllInTrash()
        {
            return gm.GetAllInTrash();
        }

        public IList<Get> GetGetBySiteInTrash(string site)
        {
            return gm.GetGetBySiteInTrash(site);
        }
    }
}
