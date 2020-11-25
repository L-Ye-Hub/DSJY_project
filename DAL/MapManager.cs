using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
  public  class MapManager
    {
        public int Add(Map Map)
        {
            string sql = "insert into Map(Map_Id,Map_Site,Map_Phone,Map_DeleteId,Map_CreateTime,Map_UpdateTime) " +
                         "values(@Map_Id,@Map_Site,@Map_Phone,@Map_DeleteId,@Map_CreateTime,@Map_UpdateTime)";

            return SqlHelper<Map>.ExceuteNonQuery(sql, Map);
        }

        public int Edit(Map Map)
        {
            string sql = "update Map set Map_Site = @Map_Site,Map_UpdateTime = @Map_UpdateTime where Map_Id = @Map_Id";
            return SqlHelper<Map>.ExceuteNonQuery(sql, Map);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Map set Map_DeleteId = 0 where Map_Id = @Map_Id";
            return SqlHelper<Map>.ExceuteNonQuery(sql, new Map() { Map_Id = id });
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            string sql = "update Map set Map_DeleteId = 1 where Map_Id = @Map_Id";
            return SqlHelper<Map>.ExceuteNonQuery(sql, new Map() { Map_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Map where Map_DeleteId = 0 and Map_Id = @Map_Id";
            return SqlHelper<Map>.ExceuteNonQuery(sql, new Map() { Map_Id = id });
        }

        public IList<Map> GetAll()
        {
            string sql = "select * from Map where Map_DeleteId = 1";
            return SqlHelper<Map>.Query(sql, null);
        }
        public Map GetMapById(Guid id)
        {
            string sql = "select * from Map where Map_Id = @Map_Id";
            return SqlHelper<Map>.Query(sql, new Map() { Map_Id = id }).FirstOrDefault();
        }
        public IList<Map> GetMapByTitle(string title)
        {
            string sql = "select * from Map where Map_DeleteId = 1 and Map_Site like @Map_Site";
            return SqlHelper<Map>.Query(sql, new Map { Map_Site= "%" + title + "%" });
        }
    }
}
