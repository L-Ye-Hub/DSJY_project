using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class MapServices
    {
        MapManager pm = new MapManager();
        public int Add(Map Map)
        {
            return pm.Add(Map);
        }

        public int Edit(Map Map)
        {
            return pm.Edit(Map);
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

        public IList<Map> GetAll()
        {
            return pm.GetAll();
        }
        public Map GetMapById(Guid id)
        {
            return pm.GetMapById(id);
        }
        public IList<Map> GetMapByTitle(string title)
        {
            return pm.GetMapByTitle(title);
        }

    }
}
