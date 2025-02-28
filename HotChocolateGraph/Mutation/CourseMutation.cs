using HotChocolate.Subscriptions;
using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Dto;

namespace HotChocolateGraph.Mutation
{
    [ExtendObjectType("Mutation")]
    public class CourseMutation
    {
        public async Task<bool> AddCourse([Service] ICourseRepository _courseRepository, Course dto,
            [Service] ITopicEventSender topicEventSender, CancellationToken cancellationToken)
        {
            try
            {
                _courseRepository.Add(dto);
                await topicEventSender.SendAsync($"{nameof(AddCourse)}_{nameof(CourseMutation)}", dto, cancellationToken);
                return true;
            }
            catch (GraphQLException)
            {
                throw;
            }
        }

        public async Task<Course> UpdateCourse([Service] ICourseRepository _courseRepository, Course dto,
            [Service] ITopicEventSender topicEventSender, CancellationToken cancellationToken)
        {
            try
            {
                _courseRepository.Update(dto);
                await topicEventSender.SendAsync($"{nameof(UpdateCourse)}_{nameof(CourseMutation)}", dto, cancellationToken);
                return dto;
            }
            catch (GraphQLException)
            {
                throw;
            }
        }
    }
}
