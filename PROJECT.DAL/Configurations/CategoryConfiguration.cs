﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PROJECT.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DAL.Configurations
{
    public class CategoryConfiguration:BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.HasMany(x=>x.Products).WithOne(x => x.Category).HasForeignKey(x=>x.CategoryID);
        }
    }
}