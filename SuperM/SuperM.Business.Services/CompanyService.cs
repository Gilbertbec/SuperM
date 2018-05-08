namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Linq;

    public class CompanyService
    {
        private SuperMContext _context;

        public CompanyService()
        {
            _context = new SuperMContext();
        }

        public dynamic GetCompanyList()
        {
            var companys = _context.Companies.Select(x => new { x.CompanyId, x.Name, x.Address, x.TelephoneNumber, x.Fax, x.Email, x.Website }).ToList();
            return companys;
        }

        public Company GetCompanyById(int companyId)
        {
            Company company = _context.Companies.FirstOrDefault(x => x.CompanyId == companyId);
            return company;
        }

        public dynamic GetCompanyListByName(string name)
        {
            var companys = _context.Companies.Where(x => x.Name.Contains(name)).Select(x => new { x.CompanyId, x.Name, x.Address, x.TelephoneNumber, x.Fax, x.Email, x.Website }).ToList();
            return companys;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (_context.Companies.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public void DeleteCompanyById(int companyId)
        {
            Company company = GetCompanyById(companyId);
            _context.Companies.Remove(company);
            _context.SaveChanges();
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
            _context.SaveChanges();
        }
    }
}
