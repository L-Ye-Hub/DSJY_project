using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class SendManager
    {
        public int Add(Send Send)
        {
            string sql = "insert into Send(Send_Id,Send_Image,Send_Content,Send_DeleteId,Send_CreateTime,Send_UpdateTime) " +
                         "values(@Send_Id,@Send_Image,@Send_Content,@Send_DeleteId,@Send_CreateTime,@Send_UpdateTime)";

            return SqlHelper<Send>.ExceuteNonQuery(sql, Send);
        }

        public int Edit(Send Send)
        {
            string sql = "update Send set Send_Image = @Send_Image ,Send_Content  = @Send_Content ,Send_UpdateTime = @Send_UpdateTime where Send_Id = @Send_Id";
            return SqlHelper<Send>.ExceuteNonQuery(sql, Send);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Send set Send_DeleteId = 0 where Send_Id = @Send_Id";
            return SqlHelper<Send>.ExceuteNonQuery(sql, new Send() { Send_Id = id });
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            string sql = "update Send set Send_DeleteId = 1 where Send_Id = @Send_Id";
            return SqlHelper<Send>.ExceuteNonQuery(sql, new Send() { Send_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Send where Send_DeleteId = 0 and Send_Id = @Send_Id";
            return SqlHelper<Send>.ExceuteNonQuery(sql, new Send() { Send_Id = id });
        }

        public IList<Send> GetAll()
        {
            string sql = "select * from Send where Send_DeleteId = 1";
            return SqlHelper<Send>.Query(sql, null);
        }

        public IList<Send> GetSendByTitle(string title)
        {
            string sql = "select * from Send where Send_DeleteId = 1 and Send_Content like @Send_Content";
            return SqlHelper<Send>.Query(sql, new Send { Send_Content = "%" + title + "%" });
        }


        public Send GetSendById(Guid id)
        {
            string sql = "select * from Send where Send_Id = @Send_Id";
            return SqlHelper<Send>.Query(sql, new Send() { Send_Id = id }).FirstOrDefault();
        }

        public IList<Send> GetAllInTrash()
        {
            string sql = "select * from Send where Send_DeleteId = 0";
            return SqlHelper<Send>.Query(sql, null);
        }

        public IList<Send> GetSendByTitleInTrash(string title)
        {
            string sql = "select * from Send where Send_DeleteId = 0 and Send_Content like @Send_Content";
            return SqlHelper<Send>.Query(sql, new Send { Send_Content = "%" + title + "%" });
        }
    }
}
