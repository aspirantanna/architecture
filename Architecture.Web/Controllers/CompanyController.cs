using Architecture.Entities.Masters;
using Architecture.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Architecture.Web.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;
        
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        // GET: Company
        public ActionResult Index()
        {
            var companies = companyService.GetCompanies();
            if (companies == null)
            {
                return HttpNotFound();
            }
            return View(companies);
        }

        // GET: Company/Details/5
        public ActionResult Details(int id)
        {
            var company = companyService.GetCompany(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            var company = new Company();
            return View(company);
        }

        // POST: Company/Create
        [HttpPost]
        public ActionResult Create(Company company)
        {
            try
            {
                // TODO: Add insert logic here
                companyService.CreateCompany(company);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            var company = companyService.GetCompany(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Company/Edit/5
        [HttpPost]
        public ActionResult Edit(Company company)
        {
            try
            {
                // TODO: Add update logic here
                companyService.EditCompany(company);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Delete/5
        public ActionResult Delete(int id)
        {
            var company = companyService.GetCompany(id);
            return View(company);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var company = companyService.GetCompany(id);
                if (company == null)
                {
                    return HttpNotFound();
                }
                companyService.DeleteCompany(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
