namespace CompanyDataBase.Entities
{
    public class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int Hrs { get; set; }
        
    }
}
