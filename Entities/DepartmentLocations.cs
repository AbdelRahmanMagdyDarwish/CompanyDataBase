namespace CompanyDataBase.Entities
{
    public class DepartmentLocations
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string Location { get; set; }
    }
}
