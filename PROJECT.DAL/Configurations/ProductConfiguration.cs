﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DAL.Configurations
{
    public class ProductConfiguration:BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.HasMany(x=>x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x=>x.ProductID).IsRequired();
        }
    }
}