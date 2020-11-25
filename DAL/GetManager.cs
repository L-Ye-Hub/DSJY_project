using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class GetManager
    {
        public int Add(Get Get)
        {
            string sql = "insert into Get(Get_Id,Get_Image,Get_Site1,Get_Phone1,Get_Site2,Get_Phone2,Get_Site3,Get_Phone3,Get_ProductId,Get_DeleteId,Get_CreateTime,Get_UpdateTime)"
                         + " values(@Get_Id,@Get_Image,@Get_Site1,@Get_Phone1,@Get_Site2,@Get_Phone2,@Get_Site3,@Get_Phone3,@Get_ProductId,@Get_DeleteId,@Get_CreateTime,@Get_UpdateTime)";
            return SqlHelper<Get>.ExceuteNonQuery(sql, Get);
        }

        public int Edit(Get Get)
        {
            string sql = "update Get set Get_Image=@Get_Image ,Get_Site1=@Get_Site1 , Get_Phone1=@Get_Phone1 ,Get_Site2=@Get_Sit2e , Get_Phone2=@Get_Phone2 ,Get_Site3=@Get_Site3 , Get_Phone3=@Get_Phone3 , Get_ProductId=@Get_ProductId, Get_UpdateTime = @Get_UpdateTime where Get_Id = @Get_Id";
            return SqlHelper<Get>.ExceuteNonQuery(sql, Get);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Get set Get_DeleteId = 0 where Get_Id = @Get_Id";
            return SqlHelper<Get>.ExceuteNonQuery(sql, new Get() { Get_Id = id });
        }

        public int Restore(Guid id)
        {
            string sql = "update Get set Get_DeleteId = 0 where Get_Id = @Get_Id";
            return SqlHelper<Get>.ExceuteNonQuery(sql, new Get() { Get_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Get where Get_DeleteId = 0 and Get_Id = @Get_Id";
            return SqlHelper<Get>.ExceuteNonQuery(sql, new Get() { Get_Id = id });
        }

        public IList<Get> GetAll()
        {
            string sql = "select * from Get where Get_DeleteId = 1 ";
            return SqlHelper<Get>.Query(sql, null);
        }

        public IList<Get> GetGetBySite(string site)
        {
            string sql = "select * from Get where Get_DeleteId = 1 and Get_Site1 like @Get_Site1 or Get_Site2 like @Get_Site2 or Get_Site3 like @Get_Site3  and Get_DeleteId = 1";
            return SqlHelper<Get>.Query(sql, new Get() { Get_Site1 = "%" + site + "%" , Get_Site2 = "%" + site + "%"  , Get_Site3 = "%" + site + "%" });
        }

        public Get GetGetByProductId(Guid id)
        {
            string sql = "select * from Get where Get_ProductId = @Get_Id and Get_DeleteId = 1";
            var a =  SqlHelper<Get>.Query(sql, new Get() { Get_Id = id }).FirstOrDefault();
            return a;
        }

        public Get GetGetById(Guid id)
        {
            string sql = "select * from Get where Get_Id = @Get_Id";
            var a = SqlHelper<Get>.Query(sql, new Get() { Get_Id = id }).FirstOrDefault();
            return a;
        }


        public IList<Get> GetAllInTrash()
        {
            string sql = "select * from Get where Get_DeleteId = 0";
            return SqlHelper<Get>.Query(sql, null);
        }

        public IList<Get> GetGetBySiteInTrash(string site)
        {
            string sql = "select * from Get where Get_DeleteId = 0 and Get_Site1 like @Get_Site1 or Get_Site2 like @Get_Site2 or Get_Site3 like @Get_Site3 ";
            return SqlHelper<Get>.Query(sql, new Get() { Get_Site1 = "%" + site + "%", Get_Site2 = "%" + site + "%", Get_Site3 = "%" + site + "%" });
        }
    }
}
