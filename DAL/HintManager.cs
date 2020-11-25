using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class HintManager
    {
        public int Add(Hint hint)
        {
            string sql = "insert into Hint(Hint_Id,Hint_Title,Hint_Phone,Hint_Image,Hint_QQ,Hint_DeleteId,Hint_CreateTime,Hint_UpdateTime)"
                         + " values(@Hint_Id,@Hint_Title,@Hint_Phone,@Hint_Image,@Hint_QQ,@Hint_DeleteId,@Hint_CreateTime,@Hint_UpdateTime)";
            return SqlHelper<Hint>.ExceuteNonQuery(sql, hint);
        }

        public int Edit(Hint hint)
        {
            string sql = "update Hint set Hint_Title=@Hint_Title ,Hint_Phone=@Hint_Phone , Hint_Image=@Hint_Image , Hint_QQ=@Hint_QQ, Hint_UpdateTime = @Hint_UpdateTime where Hint_Id = @Hint_Id";
            return SqlHelper<Hint>.ExceuteNonQuery(sql, hint);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Hint set Hint_DeleteId = 0 where Hint_Id = @Hint_Id";
            return SqlHelper<Hint>.ExceuteNonQuery(sql, new Hint() { Hint_Id = id });
        }

        public int Restore(Guid id)
        {
            string sql = "update Hint set Hint_DeleteId = 0 where Hint_Id = @Hint_Id";
            return SqlHelper<Hint>.ExceuteNonQuery(sql, new Hint() { Hint_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Hint where Hint_DeleteId = 0 and Hint_Id = @Hint_Id";
            return SqlHelper<Hint>.ExceuteNonQuery(sql, new Hint() { Hint_Id = id });
        }

        public IList<Hint> GetAll()
        {
            string sql = "select * from Hint where Hint_DeleteId = 1 ";
            return SqlHelper<Hint>.Query(sql, null);
        }

        public IList<Hint> GetHintByTitle(string title)
        {
            string sql = "select * from Hint where Hint_DeleteId = 1 and Hint_Title like @Hint_Title";
            return SqlHelper<Hint>.Query(sql, new Hint() { Hint_Title = "%" + title + "%" });
        }

        public Hint GetHintById(Guid id)
        {
            string sql = "select * from Hint where Hint_Id = @Hint_Id";
            return SqlHelper<Hint>.Query(sql, new Hint() { Hint_Id = id }).FirstOrDefault();
        }


        public IList<Hint> GetAllInTrash()
        {
            string sql = "select * from Hint where Hint_DeleteId = 0";
            return SqlHelper<Hint>.Query(sql, null);
        }

        public IList<Hint> GetHintByTitleInTrash(string title)
        {
            string sql = "select * from Hint where Hint_DeleteId = 0 and Hint_Title like @Hint_Title";
            return SqlHelper<Hint>.Query(sql, new Hint() { Hint_Title = "%" + title + "%" });
        }
    }
}
