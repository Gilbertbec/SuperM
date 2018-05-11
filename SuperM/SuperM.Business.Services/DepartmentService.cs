namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class DepartmentService
    {
        private SuperMContext Context;

        public DepartmentService()
        {
            Context = new SuperMContext();
        }

        public List<Department> GetDepartmentList()
        {
            var departments = Context.Departments.ToList();
            return departments;
        }

        public Department GetDepartmentById(int departmentId)
        {
            Department department = Context.Departments.FirstOrDefault(x => x.DepartmentId == departmentId);
            return department;
        }

        public List<Department> GetDepartmentListByName(string name)
        {
            var departments = Context.Departments.Where(x => x.Name.Contains(name)).ToList();
            return departments;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.Departments.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Department department)
        {
            Context.Departments.Add(department);
            Context.SaveChanges();
        }

        public void DeleteDepartmentById(int departmentId)
        {
            Department department = GetDepartmentById(departmentId);
            Context.Departments.Remove(department);
            Context.SaveChanges();
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
            Context.SaveChanges();
        }
    }
}
