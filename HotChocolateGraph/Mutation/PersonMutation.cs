using HotChocolate.Subscriptions;
using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Dto;
using System.Collections.Concurrent;

namespace HotChocolateGraph.Mutation
{
    [ExtendObjectType("Mutation")]
    public class PersonMutation
    {
        public async Task<bool> AddPerson([Service] IPersonRepository repository,
            Person dto, [Service] ITopicEventSender eventSender, CancellationToken cancellationToken)
        {
            try
            {
                repository.Add(dto);
                await eventSender.SendAsync($"{nameof(AddPerson)}_{nameof(PersonMutation)}", dto, cancellationToken);
                return true;
            }
            catch (GraphQLException e)
            {
                throw e;
            }

        }

        public async Task<bool> UpdatePereson([Service] IPersonRepository repository, Person dto,
            [Service] ITopicEventSender eventSender, CancellationToken cancellationToken)
        {
            try
            {
                repository.Update(dto);
                await eventSender.SendAsync($"{nameof(UpdatePereson)}_{nameof(PersonMutation)}",dto, cancellationToken);
                return true;
            }
            catch (GraphQLException e)
            {
                throw e;
            }
        }
    }
}
