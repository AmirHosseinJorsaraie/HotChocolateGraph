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
            try
            {
                return _list;
            }
            catch
            {
                throw new GraphQLException();
            }
        }

        public void Add(Course course)
        {
            try
            {
                _list.Add(course);
            }
            catch
            {
                throw new GraphQLException();
            }
        }

        public void Update(Course course)
        {
            try
            {
                Course target = _list.FirstOrDefault(x => x.Id == course.Id);
                if (target != null)
                {
                    target.TeacherId = course.TeacherId;
                    target.CourseName = course.CourseName;
                }
                else
                {
                    throw new GraphQLException(new Error("Course Not Found!", "404"));
                }
            }
            catch
            {
                throw new GraphQLException();
            }
        }
    }
}
