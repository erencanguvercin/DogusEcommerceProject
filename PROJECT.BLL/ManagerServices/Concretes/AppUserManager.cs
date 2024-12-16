using Microsoft.AspNetCore.Identity;
using PROJECT.BLL.ManagerServices.Abstracts;
using PROJECT.DAL.Repositories.Abstracts;
using PROJECT.ENTITIES.Interfaces;
using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.BLL.ManagerServices.Concretes
{
    public class AppUserManager:BaseManager<AppUser>,IAppUserManager
    {
        IAppUserRepository _iapRep;
        //public AppUserManager(IRepository<AppUser> apRep, IAppUserRepository iapRep) : base(apRep)
        //{
        //    _iapRep = iapRep;
        //}
        public AppUserManager(IAppUserRepository iapRep) : base(iapRep) 
        {
            _iapRep = iapRep;
        }
        public async Task<bool> CreateUser(AppUser item)
        {
           return await _iapRep.AddUser(item);
        }
    }
}
