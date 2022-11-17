using System.Collections.Generic;

namespace CompanyDataBase.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public float Salary { get; set; }
        public char Gender { get; set; }

        public int ? SupervisorId { get; set; }
        public Employee ? Supervisor { get; set; }
        // navigation 
        public int departmentId { get; set; }
        public Department Department { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }
        public List<Dependants>? Dependants { get; set; }
    }
}
