using Microsoft.AspNetCore.Identity;
using PROJECT.DAL.Context;
using PROJECT.DAL.Repositories.Abstracts;
using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DAL.Repositories.Concretes
{
    public class AppUserRepository:BaseRepository<AppUser>, IAppUserRepository
    {
        UserManager<AppUser> _userManager;
        public AppUserRepository(MyContext db, UserManager<AppUser> userManager):base(db)
        {
          _userManager = userManager;
        }
        public async Task<bool> AddUser(AppUser item)
        {
            IdentityResult result = await _userManager.CreateAsync(item,item.PasswordHash);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }
    }
}
