using CompanyDataBase.Context;
using CompanyDataBase.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace CompanyDataBase.Services
{
    public class DepartmentServices
    {
        private AppDbContext context;
        public DepartmentServices(AppDbContext context) 
        {
            this.context = context;
        }
        public void AddDepartment (Department department)
        {
            var dep = new Department()
            {
               Id = department.Id,
               Name = department.Name,
               ManagerId= department.ManagerId
            };
            context.Add(dep);
            context.SaveChanges();
        }
        public List<Department> getDepartment ()
        {
            var emp = context.Departments.ToList();
            return emp;
        }
        public Department GetDepartmentById(int id) 
        {
            var emp = context.Departments.FirstOrDefault(context=> context.Id == id);
            return emp;
        }
        public Department UpdateDepartment(int id , Department department) 
        {
            var emp = context.Departments.FirstOrDefault(E=> E.Id == id);
            if (emp != null)
            {

                emp.Id = department.Id;
                emp.Name = department.Name;
                emp.ManagerId = department.ManagerId;
                
            }
            context.SaveChanges();
            return emp;

        }
        public void DeleteDepartment(int id)
        {
            var emp = context.Departments.FirstOrDefault(E => E.Id == id);
            context.Remove(emp);
        }

        
    }
}
