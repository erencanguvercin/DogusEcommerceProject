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
    public class ProductManager:BaseManager<Product>,IProductManager
    {
        IProductRepository _iproRep;
        public ProductManager(IProductRepository iproRep):base(iproRep) 
        {
            _iproRep = iproRep;
        }
    }
}
