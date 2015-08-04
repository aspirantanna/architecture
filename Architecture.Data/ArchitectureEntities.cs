using Architecture.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Data
{
    public class ArchitectureEntities : IdentityDbContext<ApplicationUser>
    {
        public ArchitectureEntities() : base("ArchitectureEntities")
        {

        }
        
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
