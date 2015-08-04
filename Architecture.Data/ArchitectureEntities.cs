using Architecture.Data.Configuration;
using Architecture.Entities;
using Architecture.Entities.Masters;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Data.Models
{
    public class ArchitectureEntities : IdentityDbContext<ApplicationUser>
    {
        public ArchitectureEntities() : base("ArchitectureEntities")
        {

        }

        public DbSet<Company> Company { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Configurations.Add(new CompanyConfiguration());
        }
    }
}
