using System.Collections.Generic;

namespace CompanyDataBase.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // navigation property
        public int ManagerId { get; set; }
        public Employee Employee { get; set; }
        

        public List<Employee> Employees { get; set; }
        public List<Project> Projects { get; set; }

    }
}
