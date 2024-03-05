namespace AreaProject.Models.Entities
{
    public class Lesson : BaseEntity
    {
        public string Topic { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
    }
}
