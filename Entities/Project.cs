using System.Collections.Generic;

namespace CompanyDataBase.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        // Navigation Property
        public Department Department { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
