using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Dto;

namespace HotChocolateGraph.Query
{
    [ExtendObjectType("Query")]
    public class CourseQuery
    {
        public List<Course> GetCourses([Service] ICourseRepository repository)
        {
            return repository.GetCourses();
        }
    }
}
