using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class ProductManager
    {
        Product pr = new Product();
        public int Add(Product product)
        {
            string sql = "insert into Product(Product_Id,Product_Title,Product_Image,Product_Intro,Product_Content,Product_Price,Product_DeleteId,Product_CreateTime,Product_UpdateTime) " +
                         "values(@Product_Id,@Product_Title,@Product_Image,@Product_Intro,@Product_Content,@Product_Price,@Product_DeleteId,@Product_CreateTime,@Product_UpdateTime)";

            return SqlHelper<Product>.ExceuteNonQuery(sql,product);
        }

        public int Edit(Product product)
        {
            string sql = "update Product set Product_Title = @Product_Title ,Product_Image = @Product_Image ,Product_Intro = @Product_Intro ,Product_Content = @Product_Content,Product_Price = @Product_Price,Product_UpdateTime = @Product_UpdateTime where Product_Id = @Product_Id";
            return SqlHelper<Product>.ExceuteNonQuery(sql, product);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Product set Product_DeleteId = 0 where Product_Id = @Product_Id";
            return SqlHelper<Product>.ExceuteNonQuery(sql,new Product() { Product_Id = id });
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            string sql = "update Product set Product_DeleteId = 1 where Product_Id = @Product_Id";
            return SqlHelper<Product>.ExceuteNonQuery(sql, new Product() { Product_Id = id});
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Product where Product_DeleteId = 0 and Product_Id = @Product_Id";
            return SqlHelper<Product>.ExceuteNonQuery(sql, new Product() { Product_Id = id });
        }

        public IList<Product> GetAll()
        {
            string sql = "select * from Product where Product_DeleteId = 1";
            return SqlHelper<Product>.Query(sql, null);
        }

        public IList<Product> GetProductByTitle(string title)
        {
            string sql = "select * from Product where Product_DeleteId = 1 and Product_Title like @Product_Title";
            return SqlHelper<Product>.Query(sql, new Product { Product_Title = "%" + title + "%" });
        }


        public Product GetProductById(Guid id)
        {
            string sql = "select * from Product where Product_Id = @Product_Id";
            return SqlHelper<Product>.Query(sql, new Product() { Product_Id = id }).FirstOrDefault();
        }

        public IList<Product> GetAllInTrash()
        {
            string sql = "select * from Product where Product_DeleteId = 0";
            return SqlHelper<Product>.Query(sql, null);
        }

        public IList<Product> GetProductByTitleInTrash(string title)
        {
            string sql = "select * from Product where Product_DeleteId = 0 and Product_Title like @Product_Title";
            return SqlHelper<Product>.Query(sql, new Product { Product_Title = "%" + title + "%" });
        }


    }
}
