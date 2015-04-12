
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class Class1 : IEmployeeDao
    {

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Id = "GSS";
            employee1.Name = "叡揚資訊";
            employee1.Age = 1;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Id = "11";
            employee2.Name = "1";
            employee2.Age = 1;
            employees.Add(employee2);
            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employee = null;


            employee = new Employee();
            employee.Id = "11";
            employee.Name = "1";
            employee.Age = 1;


            return employee;
        }

    }
}
