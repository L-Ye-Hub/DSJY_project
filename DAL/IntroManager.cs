using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class IntroManager
    {
        public int Add(Intro Intro)
        {
            string sql = "insert into Intro(Intro_Id,Intro_Image,Intro_Content,Intro_DeleteId,Intro_CreateTime,Intro_UpdateTime) " +
                         "values(@Intro_Id,@Intro_Image,@Intro_Content,@Intro_DeleteId,@Intro_CreateTime,@Intro_UpdateTime)";

            return SqlHelper<Intro>.ExceuteNonQuery(sql, Intro);
        }

        public int Edit(Intro Intro)
        {
            string sql = "update Intro set Intro_Image = @Intro_Image ,Intro_Content  = @Intro_Content ,Intro_UpdateTime = @Intro_UpdateTime where Intro_Id = @Intro_Id";
            return SqlHelper<Intro>.ExceuteNonQuery(sql, Intro);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Intro set Intro_DeleteId = 0 where Intro_Id = @Intro_Id";
            return SqlHelper<Intro>.ExceuteNonQuery(sql, new Intro() { Intro_Id = id });
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            string sql = "update Intro set Intro_DeleteId = 1 where Intro_Id = @Intro_Id";
            return SqlHelper<Intro>.ExceuteNonQuery(sql, new Intro() { Intro_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Intro where Intro_DeleteId = 0 and Intro_Id = @Intro_Id";
            return SqlHelper<Intro>.ExceuteNonQuery(sql, new Intro() { Intro_Id = id });
        }

        public IList<Intro> GetAll()
        {
            string sql = "select * from Intro where Intro_DeleteId = 1";
            return SqlHelper<Intro>.Query(sql, null);
        }

        public IList<Intro> GetIntroByTitle(string title)
        {
            string sql = "select * from Intro where Intro_DeleteId = 1 and Intro_Content like @Intro_Content";
            return SqlHelper<Intro>.Query(sql, new Intro { Intro_Content = "%" + title + "%" });
        }


        public Intro GetIntroById(Guid id)
        {
            string sql = "select * from Intro where Intro_Id = @Intro_Id";
            return SqlHelper<Intro>.Query(sql, new Intro() { Intro_Id = id }).FirstOrDefault();
        }

        public IList<Intro> GetAllInTrash()
        {
            string sql = "select * from Intro where Intro_DeleteId = 0";
            return SqlHelper<Intro>.Query(sql, null);
        }

        public IList<Intro> GetIntroByTitleInTrash(string title)
        {
            string sql = "select * from Intro where Intro_DeleteId = 0 and Intro_Content like @Intro_Content";
            return SqlHelper<Intro>.Query(sql, new Intro { Intro_Content = "%" + title + "%" });
        }
    }
}
