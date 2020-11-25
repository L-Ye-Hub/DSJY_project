using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class OrderManager
    {
        public int Add(Order Order)
        {
            string sql = "insert into Order(Order_Id,Order_Name,Order_Phone,Order_Email,Order_Site,Order_relevan,Order_DeleteId,Order_CreateTime,Order_UpdateTime)"
                         + " values(@Order_Id,@Order_Name,@Order_Phone,@Order_Email,@Order_Site,@Order_relevan,@Order_DeleteId,@Order_CreateTime,@Order_UpdateTime)";
            return SqlHelper<Order>.ExceuteNonQuery(sql, Order);
        }
        public int PutTrash(Guid id)
        {
            string sql = "update Order set Order_DeleteId = 0 where Order_Id = @Order_Id";
            return SqlHelper<Order>.ExceuteNonQuery(sql, new Order() { Order_Id = id });
        }

        public int Restore(Guid id)
        {
            string sql = "update Order set Order_DeleteId = 0 where Order_Id = @Order_Id";
            return SqlHelper<Order>.ExceuteNonQuery(sql, new Order() { Order_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Order where Order_DeleteId = 0 and Order_Id = @Order_Id";
            return SqlHelper<Order>.ExceuteNonQuery(sql, new Order() { Order_Id = id });
        }

        public IList<Order> GetAll()
        {
            string sql = "select * from Order where Order_DeleteId = 1 ";
            return SqlHelper<Order>.Query(sql, null);
        }

        public IList<Order> GetOrderByName(string name)
        {
            string sql = "select * from Order where Order_DeleteId = 1 and Order_Name like @Order_Name";
            return SqlHelper<Order>.Query(sql, new Order() { Order_Name = "%" + name + "%" });
        }

        public Order GetOrderById(Guid id)
        {
            string sql = "select * from Order where Order_Id = @Order_Id";
            return SqlHelper<Order>.Query(sql, new Order() { Order_Id = id }).FirstOrDefault();
        }


        public IList<Order> GetAllInTrash()
        {
            string sql = "select * from Order where Order_DeleteId = 0";
            return SqlHelper<Order>.Query(sql, null);
        }

        public IList<Order> GetOrderByNameInTrash(string name)
        {
            string sql = "select * from Order where Order_DeleteId = 0 and Order_Name like @Order_Name";
            return SqlHelper<Order>.Query(sql, new Order() { Order_Name = "%" + name + "%" });
        }
    }
}
