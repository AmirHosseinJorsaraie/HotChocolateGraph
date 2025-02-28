using HotChocolateGraph.Dto;
using HotChocolateGraph.Mutation;

namespace HotChocolateGraph.Subscription
{
    [ExtendObjectType("Subscription")]
    public class CourseSubscription
    {
        [Subscribe]
        [Topic($"{nameof(CourseMutation.AddCourse)}_{nameof(CourseMutation)}")]
        public Course OnAddCourse([EventMessage] Course course) => course;
        
        [Subscribe]
        [Topic($"{nameof(CourseMutation.UpdateCourse)}_{nameof(CourseMutation)}")]
        public Course OnUpdateCourse([EventMessage] Course course) => course;
    }
}
