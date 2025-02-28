using HotChocolate.Subscriptions;
using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Dto;
using System.Collections.Concurrent;

namespace HotChocolateGraph.Mutation
{
    [ExtendObjectType("Mutation")]
    public class PersonMutation
    {
        public async Task<bool> Add([Service] IPersonRepository repository,
            Person dto, [Service] ITopicEventSender eventSender, CancellationToken cancellationToken)
        {
            try
            {
                repository.Add(dto);
                await eventSender.SendAsync($"{nameof(Add)}_{nameof(PersonMutation)}", dto, cancellationToken);
                return true;
            }
            catch (GraphQLException e)
            {
                throw e;
            }

        }

        public async Task<bool> Update([Service] IPersonRepository repository, Person dto,
            [Service] ITopicEventSender eventSender, CancellationToken cancellationToken)
        {
            try
            {
                ConcurrentBag<Person> persons = new ConcurrentBag<Person>();
                repository.Update(dto);
                await eventSender.SendAsync($"{nameof(Update)}_{nameof(PersonMutation)}",dto, cancellationToken);
                return true;
            }
            catch (GraphQLException e)
            {
                throw e;
            }
        }
    }
}
