using CompanyDataBase.Context;
using CompanyDataBase.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Xml.Linq;

namespace CompanyDataBase.Services
{
    public class EmployeeServices
    {
        private AppDbContext context;
        public EmployeeServices(AppDbContext context) 
        {
            this.context = context;
        }
        public Employee AddEmployee (Employee employee)
        {
            var emp = new Employee()
            {
                Id = employee.Id,
                FName = employee.FName,
                LName = employee.LName,
                Salary = employee.Salary,
                Gender = employee.Gender,
                Supervisor = employee.Supervisor,
                Department = employee.Department
            };
            context.Add(emp);
            context.SaveChanges();
            return emp; 
        }
        public List<Employee> getEmployees ()
        {
            var emp = context.Employees.ToList();
            return emp;
        }
        public Employee GetEmployeeById(int id) 
        {
            var emp = context.Employees.FirstOrDefault(context=> context.Id == id);
            return emp;
        }
        public Employee UpdateEmployee(int id , Employee employee) 
        {
            var emp = context.Employees.FirstOrDefault(E=> E.Id == id);
            if (emp != null)
            {

                emp.FName = employee.FName;
                emp.LName = employee.LName;
                emp.Salary = employee.Salary;
                emp.Gender = employee.Gender;
                emp.Supervisor = employee.Supervisor;
                emp.Department = employee.Department;
            }
            context.SaveChanges();
            return emp;

        }
        public void DeleteEmployee(int id)
        {
            var emp = context.Employees.FirstOrDefault(E => E.Id == id);
            context.Remove(emp);
        }

        
    }
}
