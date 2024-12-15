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
    public class CategoryRepository:BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MyContext db):base(db)
        {
            
        }
    }
}
