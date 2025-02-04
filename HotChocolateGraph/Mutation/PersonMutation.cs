using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Dto;

namespace HotChocolateGraph.Mutation
{
    [ExtendObjectType("Mutation")]
    public class PersonMutation
    {
        public bool AddPerson([Service] IPersonRepository repository, Person dto)
        {
            try
            {
                repository.Add(dto);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
