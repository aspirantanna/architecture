﻿using Architecture.Data.Infrastructure;
using Architecture.Entities.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Data.Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(IDatabaseFactory databaseFactory):base(databaseFactory)
        {

        }
    }

    public interface ICompanyRepository : IRepository<Company>
    {
    }
}
