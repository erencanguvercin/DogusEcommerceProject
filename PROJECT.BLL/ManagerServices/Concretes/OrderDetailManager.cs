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
    public class OrderDetailManager:BaseManager<OrderDetail>,IOrderDetailManager
    {
        IOrderDetailRepository _iodRep;
        public OrderDetailManager(IOrderDetailRepository iodRep):base(iodRep)
        {
            _iodRep = iodRep;
        }
    }
}
