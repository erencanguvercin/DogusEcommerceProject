using PROJECT.BLL.ManagerServices.Abstracts;
using PROJECT.DAL.Repositories.Abstracts;
using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.BLL.ManagerServices.Concretes
{
    public class OrderManager:BaseManager<Order>,IOrderManager
    {
        IOrderRepository _ioRep;
        public OrderManager(IOrderRepository ioRep):base(ioRep) 
        {
            _ioRep = ioRep;
        }
    }
}
