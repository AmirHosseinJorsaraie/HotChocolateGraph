using HotChocolateGraph.Dto;
using HotChocolateGraph.Mutation;

namespace HotChocolateGraph.Subscription
{
    [ExtendObjectType("Subscription")]
    public class PersonSubscription
    {
        [Subscribe]
        [Topic($"{nameof(PersonMutation.Add)}_{nameof(PersonMutation)}")]
        public Person OnAdd([EventMessage] Person person) => person;

        [Subscribe]
        [Topic($"{nameof(PersonMutation.Update)}_{nameof(PersonMutation)}")]
        public Person OnUpdate([EventMessage] Person person) => person; 
    }
}
