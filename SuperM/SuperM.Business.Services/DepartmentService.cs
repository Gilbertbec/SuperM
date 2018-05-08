namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class DepartmentService
    {
        private SuperMContext _context;

        public DepartmentService()
        {
            _context = new SuperMContext();
        }

        public List<Department> GetDepartmentList()
        {
            var departments = _context.Departments.ToList();
            return departments;
        }

        public Department GetDepartmentById(int departmentId)
        {
            Department department = _context.Departments.FirstOrDefault(x => x.DepartmentId == departmentId);
            return department;
        }

        public List<Department> GetDepartmentListByName(string name)
        {
            var departments = _context.Departments.Where(x => x.Name.Contains(name)).ToList();
            return departments;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (_context.Departments.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public void DeleteDepartmentById(int departmentId)
        {
            Department department = GetDepartmentById(departmentId);
            _context.Departments.Remove(department);
            _context.SaveChanges();
        }

        public void UpdateDepartmentByDepartment(Department department)
        {
            var Department = GetDepartmentById(department.DepartmentId);
            if (Department != null)
            {
                Department.DepartmentId = department.DepartmentId;
                Department.Name = department.Name;
                Department.CompanyId = department.CompanyId;
                Department.Company = department.Company;
            }
            _context.SaveChanges();
        }
    }
}
