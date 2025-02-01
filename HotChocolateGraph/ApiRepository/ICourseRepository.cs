using HotChocolateGraph.Dto;

namespace HotChocolateGraph.ApiRepository
{
    public interface ICourseRepository
    {
        void Add(Course course);
        List<Course> GetCourses();
        void Update(Course course);
    }
}