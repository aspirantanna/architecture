using Architecture.Data.Infrastructure;
using Architecture.Data.Repository;
using Architecture.Entities.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Service
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompany(int companyId);
        void CreateCompany(Company company);
        void EditCompany(Company company);
        void DeleteCompany(int CompanyId);
        void SaveCompany();
    }

    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IUnitOfWork unitOfWork;

        public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork)
        {
            this.companyRepository = companyRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Company> GetCompanies()
        {
            var companies = companyRepository.GetAll();
            return companies;
        }

        public Company GetCompany(int companyId)
        {
            var company = companyRepository.GetById(companyId);
            return company;
        }

        public void CreateCompany(Company company)
        {
            companyRepository.Add(company);
            SaveCompany();
        }

        public void EditCompany(Company company)
        {
            companyRepository.Update(company);
            SaveCompany();
        }

        public void DeleteCompany(int CompanyId)
        {
            var company = companyRepository.GetById(CompanyId);
            companyRepository.Delete(company);
            SaveCompany();
        }

        public void SaveCompany()
        {
            unitOfWork.Commit();
        }
    }
}
