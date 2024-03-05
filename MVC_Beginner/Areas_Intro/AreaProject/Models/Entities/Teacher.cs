namespace AreaProject.Models.Entities
{
    public class Teacher : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClassID { get; set; }
        public Class Class { get; set; }
    }
}
