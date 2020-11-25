using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
  public class BookManager
    {
        public int Add(Book Book)
        {
            string sql = "insert into Book(Book_Id,Book_Title,Book_Content,Book_Image  ,Book_Price,Book_publish,Book_Author,Book_Intro,Book_Catalog ,Book_Read ,Book_DeleteId,Book_CreateTime,Book_UpdateTime) " +
                         "values(@Book_Id,@Book_Title,@Book_Content,@Book_Image  ,@Book_Price,@Book_publish,@Book_Author,@Book_Intro,@Book_Catalog ,@Book_Read ,@Book_DeleteId,@Book_CreateTime,@Book_UpdateTime)";

            return SqlHelper<Book>.ExceuteNonQuery(sql, Book);
        }

        public int Edit(Book Book)
        {
            string sql = "update Book set Book_Image = @Book_Image ,Book_Content  = @Book_Content ,Book_UpdateTime = @Book_UpdateTime where Book_Id = @Book_Id";
            return SqlHelper<Book>.ExceuteNonQuery(sql, Book);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Book set Book_DeleteId = 0 where Book_Id = @Book_Id";
            return SqlHelper<Book>.ExceuteNonQuery(sql, new Book() { Book_Id = id });
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            string sql = "update Book set Book_DeleteId = 1 where Book_Id = @Book_Id";
            return SqlHelper<Book>.ExceuteNonQuery(sql, new Book() { Book_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Book where Book_DeleteId = 0 and Book_Id = @Book_Id";
            return SqlHelper<Book>.ExceuteNonQuery(sql, new Book() { Book_Id = id });
        }

        public IList<Book> GetAll()
        {
            string sql = "select * from Book where Book_DeleteId = 1";
            return SqlHelper<Book>.Query(sql, null);
        }

        public IList<Book> GetBookByTitle(string title)
        {
            string sql = "select * from Book where Book_DeleteId = 1 and Book_Content like @Book_Content";
            return SqlHelper<Book>.Query(sql, new Book { Book_Content = "%" + title + "%" });
        }


        public Book GetBookById(Guid id)
        {
            string sql = "select * from Book where Book_Id = @Book_Id";
            return SqlHelper<Book>.Query(sql, new Book() { Book_Id = id }).FirstOrDefault();
        }

        public IList<Book> GetAllInTrash()
        {
            string sql = "select * from Book where Book_DeleteId = 0";
            return SqlHelper<Book>.Query(sql, null);
        }

        public IList<Book> GetBookByTitleInTrash(string title)
        {
            string sql = "select * from Book where Book_DeleteId = 0 and Book_Content like @Book_Content";
            return SqlHelper<Book>.Query(sql, new Book { Book_Content = "%" + title + "%" });
        }
    }
}
