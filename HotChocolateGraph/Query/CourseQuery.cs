using HotChocolateGraph.Dto;

namespace HotChocolateGraph.Query
{
    [ExtendObjectType("Query")]
    public class CourseQuery
    {
        public List<Course> GetCourses() => new List<Course> {
            new Course { Id = 1, TeacherId = 12, CourseName = "C1" },
            new Course { Id = 2, TeacherId = 15, CourseName = "C2" }
        };
    }
}
