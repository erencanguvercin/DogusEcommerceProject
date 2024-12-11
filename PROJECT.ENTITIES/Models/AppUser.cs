using Microsoft.AspNetCore.Identity;
using PROJECT.ENTITIES.Enums;
using PROJECT.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.ENTITIES.Models
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get ; set ; } 
        public DateTime CreatedDate { get ; set ; }
        public DateTime? ModifiedDate { get ; set ; }
        public DateTime? DeletedDate { get ; set ; }
        public DataStatus Status { get ; set ; }

        //Relational Properties
        public virtual AppUserProfile AppUserProfile { get ; set ; }
        public virtual List<Order> Orders { get ; set ; }
    }
}
