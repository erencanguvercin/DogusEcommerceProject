using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.BLL.ManagerServices.Abstracts
{
    public interface IAppUserManager: IManager<AppUser>
    {
        Task<bool> CreateUser(AppUser item);
    }
}
