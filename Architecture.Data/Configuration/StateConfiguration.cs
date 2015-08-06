using Architecture.Entities.Masters;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Data.Configuration
{
    public class StateConfiguration:EntityTypeConfiguration<State>
    {
        public StateConfiguration()
        {
            Property(c => c.StateName).HasMaxLength(250);
        }
    }
}
