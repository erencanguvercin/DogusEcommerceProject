using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DAL.Configurations
{
    public class OrderConfiguration:BaseConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.HasMany(x=>x.OrderDetails).WithOne(x=>x.Order).HasForeignKey(x=>x.OrderID).IsRequired();
        }
    }
}
