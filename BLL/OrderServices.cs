using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class OrderServices
    {
        OrderManager om = new OrderManager();
        public int Add(Order Order)
        {
            return om.Add(Order);
        }
        public int PutTrash(Guid id)
        {
            return om.PutTrash(id);
        }

        public int Restore(Guid id)
        {
            return om.Restore(id);
        }

        public int Delete(Guid id)
        {
            return om.Delete(id);
        }

        public IList<Order> GetAll()
        {
            return om.GetAll();
        }

        public IList<Order> GetOrderByName(string name)
        {
            return om.GetOrderByName(name);
        }

        public Order GetOrderById(Guid id)
        {
            return om.GetOrderById(id);
        }


        public IList<Order> GetAllInTrash()
        {
            return om.GetAllInTrash();
        }

        public IList<Order> GetOrderByNameInTrash(string name)
        {
            return om.GetOrderByNameInTrash(name);
        }
    }
}
