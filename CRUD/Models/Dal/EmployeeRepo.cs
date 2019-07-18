using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models.Dal
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private EmployeeContext _context;
        public EmployeeRepo(EmployeeContext EmpContext) => this._context = EmpContext;


        // Delete one employee
        public void DeleteEmp(int EmpID)
        {
            Employee emp = _context.Employees.Find(EmpID);
            _context.Employees.Remove(emp);
        }

        // Get one employee
        public Employee GetEmpByID(int empID) => _context.Employees.Find(empID);

        // Get all Employees
        public IEnumerable<Employee> GetEmps() => _context.Employees.ToList();

        //insert one employee
        public void InsertEmp(Employee employee) => _context.Employees.Add(employee);
        
         // Update one employee
        public void UpdateEmp(Employee employee)
        {
            Employee emp = _context.Employees.FirstOrDefault(e => e.ID == employee.ID);
            emp.Name = employee.Name;
            emp.Age = employee.Age;
            emp.Address = employee.Address;
            emp.Position = employee.Position;
          
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //save changes
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}