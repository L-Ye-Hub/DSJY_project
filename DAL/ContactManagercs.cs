using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class ContactManagercs
    {
        public int Add(Contact Contact)
        {
            string sql = "insert into Contact(Contact_Id, Contact_Title1 , Contact_Phone, Contact_Fax , Contact_Email , Contact_Title2 ,  Contact_Site  , Contact_Image1 ,Contact_Image2  , Contact_Image3 ,Contact_DeleteId,Contact_CreateTime,Contact_UpdateTime) " +
                         "values(@Contact_Id,@Contact_Title1, @Contact_Phone ,@Contact_Fax, @Contact_Email , @Contact_Title2 , @Contact_Site  ,@Contact_Image1 ,@Contact_Image2   , @Contact_Image3  , @Contact_DeleteId ,@Contact_CreateTime,@Contact_UpdateTime)";

            return SqlHelper<Contact>.ExceuteNonQuery(sql, Contact);
        }

        public int Edit(Contact Contact)
        {
            string sql = "update Contact set Contact_Title1 = @Contact_Title1 ,Contact_Phone = @Contact_Phone ,Contact_Fax = @Contact_Fax ,Contact_Email  = @Contact_Email , Contact_Title2 = @Contact_Title2 ,  Contact_Site  = @Contact_Site  ,  Contact_Image1 = @Contact_Image1 ,  Contact_Image2  = @Contact_Image2  ,  Contact_Image3  = @Contact_Image3  ,  Contact_UpdateTime = @Contact_UpdateTime where Contact_Id = @Contact_Id";
            return SqlHelper<Contact>.ExceuteNonQuery(sql, Contact);
        }
        public int Delete(Guid id)
        {
            string sql = "delete from Contact where Contact_DeleteId = 0 and Contact_Id = @Contact_Id";
            return SqlHelper<Contact>.ExceuteNonQuery(sql, new Contact() { Contact_Id = id });
        }
        public int PutTrash(Guid id)
        {
            string sql = "update Contact set Contact_DeleteId = 0 where Contact_Id = @Contact_Id";
            return SqlHelper<Contact>.ExceuteNonQuery(sql, new Contact() { Contact_Id = id });
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<Contact> GetAll()
        {
            string sql = "select * from Contact where Contact_DeleteId = 1";
            return SqlHelper<Contact>.Query(sql, null);
        }

        public IList<Contact> GetContactByTitle(string title)
        {
            string sql = "select * from Contact where Contact_DeleteId = 1 and Contact_Title1 like @Contact_Title1";
            return SqlHelper<Contact>.Query(sql, new Contact { Contact_Title1 = "%" + title + "%" });
        }


        public Contact GetContactById(Guid id)
        {
            string sql = "select * from Contact where Contact_Id = @Contact_Id";
            return SqlHelper<Contact>.Query(sql, new Contact() { Contact_Id = id }).FirstOrDefault();
        }

        public IList<Contact> GetAllInTrash()
        {
            string sql = "select * from Contact where Contact_DeleteId = 0";
            return SqlHelper<Contact>.Query(sql, null);
        }

        public IList<Contact> GetContactByTitleInTrash(string title)
        {
            string sql = "select * from Contact where Contact_DeleteId = 0 and Contact_Title1 like @Contact_Title1";
            return SqlHelper<Contact>.Query(sql, new Contact { Contact_Title1 = "%" + title + "%" });
        }
    }
}
