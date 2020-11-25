using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class CultureManager
    {
        public int Add(Culture Culture)
        {
            string sql = "insert into Culture(Culture_Id,Culture_Intro,Culture_Title1 ,Culture_Content1,Culture_Title2 ,Culture_Content2,Culture_Title3 ,Culture_Content3,Culture_Title4 ,Culture_Content4,Culture_Title5 ,Culture_Content5,Culture_DeleteId,Culture_CreateTime,Culture_UpdateTime) " +
                         "values(@Culture_Id,@Culture_Intro,@Culture_Title1 ,@Culture_Content1,@Culture_Title2 ,@Culture_Content2,@Culture_Title3 ,@Culture_Content3,@Culture_Title4 ,@Culture_Content4,@Culture_Title5 ,@Culture_Content5,@Culture_DeleteId,@Culture_CreateTime,@Culture_UpdateTime)";

            return SqlHelper<Culture>.ExceuteNonQuery(sql, Culture);
        }

        public int Edit(Culture Culture)
        {
            string sql = "update Culture set Culture_Intro = @Culture_Intro ,Culture_Title1  = @Culture_Title1 , Culture_Content1 = @Culture_Content1,Culture_Title2  = @Culture_Title2 , Culture_Content2 = @Culture_Content2,Culture_Title3  = @Culture_Title3 , Culture_Content3 = @Culture_Content3,Culture_Title4  = @Culture_Title4 , Culture_Content4 = @Culture_Content4,Culture_Title5  = @Culture_Title5 , Culture_Content5 = @Culture_Content5,Culture_UpdateTime = @Culture_UpdateTime where Culture_Id = @Culture_Id";
            return SqlHelper<Culture>.ExceuteNonQuery(sql, Culture);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Culture set Culture_DeleteId = 0 where Culture_Id = @Culture_Id";
            return SqlHelper<Culture>.ExceuteNonQuery(sql, new Culture() { Culture_Id = id });
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            string sql = "update Culture set Culture_DeleteId = 1 where Culture_Id = @Culture_Id";
            return SqlHelper<Culture>.ExceuteNonQuery(sql, new Culture() { Culture_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Culture where Culture_DeleteId = 0 and Culture_Id = @Culture_Id";
            return SqlHelper<Culture>.ExceuteNonQuery(sql, new Culture() { Culture_Id = id });
        }

        public IList<Culture> GetAll()
        {
            string sql = "select * from Culture where Culture_DeleteId = 1";
            return SqlHelper<Culture>.Query(sql, null);
        }

        public IList<Culture> GetCultureByTitle(string title)
        {
            string sql = "select * from Culture where Culture_DeleteId = 1 and Culture_Title1 like @Culture_Title1";
            return SqlHelper<Culture>.Query(sql, new Culture { Culture_Title1 = "%" + title + "%" });
        }


        public Culture GetCultureById(Guid id)
        {
            string sql = "select * from Culture where Culture_Id = @Culture_Id";
            return SqlHelper<Culture>.Query(sql, new Culture() { Culture_Id = id }).FirstOrDefault();
        }

        public IList<Culture> GetAllInTrash()
        {
            string sql = "select * from Culture where Culture_DeleteId = 0";
            return SqlHelper<Culture>.Query(sql, null);
        }

        public IList<Culture> GetCultureByTitleInTrash(string title)
        {
            string sql = "select * from Culture where Culture_DeleteId = 0 and Culture_Title1 like @Culture_Title1";
            return SqlHelper<Culture>.Query(sql, new Culture { Culture_Title1 = "%" + title + "%" });
        }
    }
}
