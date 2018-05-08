namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeeService
    {
        private SuperMContext _context;

        public EmployeeService()
        {
            _context = new SuperMContext();
        }

        public dynamic GetEmployeeList()
        {
            var employees = _context.Employees.Select(x => new { x.EmployeeId, x.Name, x.Gender, DepartmentName = x.Department.Name, PositionName = x.Position.Name, x.FirstName, x.MiddleName, x.Language, x.Education, x.Profession, x.Specialty, x.FamilyAddress, x.BirthDay, x.EntryTime, x.EmergencyContact, x.Photo }).ToList();
            return employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            Employee employee = _context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
            return employee;
        }

        public List<Employee> GetEmployeeListByName(string name)
        {
            var employees = _context.Employees.Where(x => x.Name.Contains(name)).ToList();
            return employees;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (_context.Employees.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployeeById(int employeeId)
        {
            Employee employee = GetEmployeeById(employeeId);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployeeByEmployee(Employee employee)
        {
            var Employee = GetEmployeeById(employee.EmployeeId);
            if (Employee != null)
            {
                Employee.EmployeeId = employee.EmployeeId;
                Employee.Name = employee.Name;
                Employee.PositionId = employee.PositionId;
                Employee.DepartmentId = employee.DepartmentId;
                Employee.FirstName = employee.FirstName;
                Employee.MiddleName = employee.MiddleName;
                Employee.LastName = employee.LastName;
                Employee.Gender = employee.Gender;
                Employee.BirthDay = employee.BirthDay;
                Employee.EntryTime = employee.EntryTime;
                Employee.Education = employee.Education;
                Employee.Profession = employee.Profession;
                Employee.Language = employee.Language;
                Employee.Specialty = employee.Specialty;
                Employee.FamilyAddress = employee.FamilyAddress;
                Employee.EmergencyContact = employee.EmergencyContact;
                Employee.Photo = employee.Photo;
            }
            _context.SaveChanges();
        }
    }
}
