using AreaProject.Models.Entities;

namespace AreaProject.SeedData
{
    public class Data
    {
        public static List<Class> Classes = new List<Class>()
        {
            new Class(){ ID=1,Teacher = Teachers.FirstOrDefault(x=>x.ClassID == 1),Students = Students.Where(x=>x.ClassID ==1) }
        };

        public static List<Student> Students = new List<Student>()
        {
            new Student(){ ID=1,FirstName="Ögrenci",LastName ="Veli",ClassID=1,Lesson = Lessons.Where(x => x.ID==1).ToList()}
        };

        public static List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher(){ID=1,FirstName="Görkem", LastName ="Hoşca",ClassID=1},
        };

        public static List<Lesson> Lessons = new List<Lesson>()
        {
            new Lesson(){ID=1,Topic = "Math"},
            new Lesson(){ID=2,Topic = "Physic"}
        };
    }
}
