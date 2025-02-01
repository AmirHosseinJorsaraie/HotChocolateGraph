using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Dto;

namespace HotChocolateGraph.Query
{
    [ExtendObjectType("Query")]
    public class PersonQuery
    {
        public List<Person> GetPeople([Service] IPersonRepository repository)
        {
            return repository.GetPeople();
        }
    }
}
