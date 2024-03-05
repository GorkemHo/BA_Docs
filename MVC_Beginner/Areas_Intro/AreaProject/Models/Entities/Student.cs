namespace AreaProject.Models.Entities
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Class Class { get; set; }
        public int ClassID { get; set; }
        public List<Lesson> Lesson { get; set; }
    }
}
