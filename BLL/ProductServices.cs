using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class ProductServices
    {
        ProductManager pm = new ProductManager();
        public int Add(Product product)
        {
            return pm.Add(product);
        }

        public int Edit(Product product)
        {
            return pm.Edit(product);
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

        public IList<Product> GetAll()
        {
            return pm.GetAll();
        }

        public IList<Product> GetProductByTitle(string title)
        {
            return pm.GetProductByTitle(title);
        }


        public Product GetProductById(Guid id)
        {
            return pm.GetProductById(id);
        }

        public IList<Product> GetAllInTrash()
        {
            return pm.GetAllInTrash();
        }

        public IList<Product> GetProductByTitleInTrash(string title)
        {
            return pm.GetProductByTitleInTrash(title);
        }
    }
}
