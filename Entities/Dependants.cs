namespace CompanyDataBase.Entities
{
    public class Dependants
    {
        public string Name { get; set; }
        public char Gender { get; set; }
        public string Relation { get; set; }

        // navigation
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
