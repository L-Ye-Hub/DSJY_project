using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
   public class BookServices
    {
        BookManager pm = new BookManager();
        public int Add(Book Book)
        {
            return pm.Add(Book);
        }

        public int Edit(Book Book)
        {
            return pm.Edit(Book);
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

        public IList<Book> GetAll()
        {
            return pm.GetAll();
        }

        public IList<Book> GetBookByTitle(string title)
        {
            return pm.GetBookByTitle(title);
        }


        public Book GetBookById(Guid id)
        {
            return pm.GetBookById(id);
        }

        public IList<Book> GetAllInTrash()
        {
            return pm.GetAllInTrash();
        }

        public IList<Book> GetBookByTitleInTrash(string title)
        {
            return pm.GetBookByTitleInTrash(title);
        }
    }
}
