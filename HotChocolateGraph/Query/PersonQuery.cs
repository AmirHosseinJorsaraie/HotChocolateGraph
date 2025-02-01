using HotChocolateGraph.Dto;

namespace HotChocolateGraph.Query
{
    [ExtendObjectType("Query")]
    public class PersonQuery
    {
        public List<Person> GetPeople() => new List<Person> {
            new Person { Id = 1, Age = 12, Name = "T1" },
            new Person { Id = 2, Age = 15, Name = "T2" }
        };
    }
}
