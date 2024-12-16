using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PROJECT.DAL.Context;
using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.BLL.DependencyResolvers
{
    public static class IdentityExtensionService
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>(x =>
            {
                x.Password.RequiredUniqueChars = 0;
                x.Password.RequiredLength = 5;
            }).AddEntityFrameworkStores<MyContext>();
            return services;
        }
    }
}
