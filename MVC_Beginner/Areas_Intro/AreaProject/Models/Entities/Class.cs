namespace AreaProject.Models.Entities
{
    public class Class : BaseEntity
    {
        public Teacher Teacher { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
