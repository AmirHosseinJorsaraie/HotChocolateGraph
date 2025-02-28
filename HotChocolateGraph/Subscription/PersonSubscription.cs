using HotChocolateGraph.Dto;
using HotChocolateGraph.Mutation;

namespace HotChocolateGraph.Subscription
{
    [ExtendObjectType("Subscription")]
    public class PersonSubscription
    {
        [Subscribe]
        [Topic($"{nameof(PersonMutation.AddPerson)}_{nameof(PersonMutation)}")]
        public Person OnAddPerson([EventMessage] Person person) => person;

        [Subscribe]
        [Topic($"{nameof(PersonMutation.UpdatePereson)}_{nameof(PersonMutation)}")]
        public Person OnUpdatePerson([EventMessage] Person person) => person; 
    }
}
