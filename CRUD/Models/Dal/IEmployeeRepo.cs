using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models.Dal
{
    interface IEmployeeRepo : IDisposable
    {
        IEnumerable<Employee> GetEmps();
        Employee GetEmpByID(int empID);
        void InsertEmp(Employee emp);
        void DeleteEmp(int EmpID);
        void UpdateEmp(Employee emp);
        void Save();
    }
}
