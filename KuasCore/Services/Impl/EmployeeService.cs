using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    public class EmployeeService : IEmployeeService
    {

        public IEmployeeDao EmployeeDao = new EmployeeDao();

        public IList<Employee> GetAllEmployees()
        {
            return EmployeeDao.GetAllEmployees();
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employee = null;

            if ("1".Equals(id))
            {
                employee = new Employee();
                employee.Id = "1";
                employee.Name = "1";
            }

            return employee;
        }

    }

}
