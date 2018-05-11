namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Linq;

    public class CompanyService
    {
        private SuperMContext Context;

        public CompanyService()
        {
            Context = new SuperMContext();
        }

        public dynamic GetCompanyList()
        {
            var companys = Context.Companies.Select(x => new { x.CompanyId, x.Name, x.Address, x.TelephoneNumber, x.Fax, x.Email, x.Website }).ToList();
            return companys;
        }

        public Company GetCompanyById(int companyId)
        {
            Company company = Context.Companies.FirstOrDefault(x => x.CompanyId == companyId);
            return company;
        }

        public dynamic GetCompanyListByName(string name)
        {
            var companys = Context.Companies.Where(x => x.Name.Contains(name)).Select(x => new { x.CompanyId, x.Name, x.Address, x.TelephoneNumber, x.Fax, x.Email, x.Website }).ToList();
            return companys;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.Companies.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Company company)
        {
            Context.Companies.Add(company);
            Context.SaveChanges();
        }

        public void DeleteCompanyById(int companyId)
        {
            Company company = GetCompanyById(companyId);
            Context.Companies.Remove(company);
            Context.SaveChanges();
        }

        public void UpdateCompanyByCompany(Company company)
        {
            var Company = GetCompanyById(company.CompanyId);
            if (Company != null)
            {
                Company.CompanyId = company.CompanyId;
                Company.Name = company.Name;
                Company.Address = company.Address;
                Company.TelephoneNumber = company.TelephoneNumber;
                Company.Fax = company.Fax;
                Company.Email = company.Email;
                Company.Website = company.Website;
                Company.FatherCompanyId = company.FatherCompanyId;
            }
            Context.SaveChanges();
        }
    }
}
