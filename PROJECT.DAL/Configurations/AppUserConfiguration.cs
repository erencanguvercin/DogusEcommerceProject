using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DAL.Configurations
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x=>x.ID);
            builder.HasOne(x => x.AppUserProfile).WithOne(x=>x.AppUser).HasForeignKey<AppUserProfile>(x=>x.ID);
            builder.HasMany(x=>x.Orders).WithOne(x=>x.AppUser).HasForeignKey(x=>x.AppUser.ID); 
        }
    }
}
