using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Dto;

namespace HotChocolateGraph.Mutation
{
    [ExtendObjectType("Mutation")]
    public class PersonMutation
    {
        public bool Add([Service] IPersonRepository repository, Person dto)
        {
            try
            {
                repository.Add(dto);
                return true;
            }
            catch(GraphQLException e)
            {
                throw e;
            }

        }

        public bool Update([Service] IPersonRepository repository, Person person)
        {
            try
            {
                repository.Update(person);
                return true;
            }
            catch(GraphQLException e)
            {
                throw e;
            }
        }
    }
}
