using HotChocolateGraph.Dto;

namespace HotChocolateGraph.ApiRepository
{
    public interface IPersonRepository
    {
        List<Person> GetPeople();
        void Add(Person person);
        void Update(Person person);

    }
}
