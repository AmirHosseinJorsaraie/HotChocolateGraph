using HotChocolateGraph.Dto;

namespace HotChocolateGraph.ApiRepository
{
    public class CourseRepository : ICourseRepository
    {
        private List<Course> _list = new List<Course>()
        {
            new Course { Id = 1, TeacherId = 12, CourseName = "C1" },
            new Course { Id = 2, TeacherId = 15, CourseName = "C2" }
        };

        public List<Course> GetCourses()
        {
            return _list;
        }

        public void Add(Course course)
        {
            _list.Add(course);
        }

        public void Update(Course course)
        {
            Course target = _list.FirstOrDefault(x => x.Id == course.Id);
            if (target != null)
            {
                target.TeacherId = course.TeacherId;
                target.CourseName = course.CourseName;
            }
        }
    }
}
