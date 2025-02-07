using HotChocolateGraph.Dto;

namespace HotChocolateGraph.ApiRepository
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> _list = new List<Person>()
        {
            new Person { Id = 1, Age = 12, Name = "T1" },
            new Person { Id = 2, Age = 15, Name = "T2" }
        };

        public void Add(Person person)
        {
            try
            {
                _list.Add(person);
            }
            catch
            {
                throw new GraphQLException();
            }
        }

        public List<Person> GetPeople()
        {
            try
            {
                return _list;
            }
            catch
            {
                throw new GraphQLException();
            }
        }

        public void Update(Person person)
        {
            try
            {
                var target = _list.FirstOrDefault(x => x.Id == person.Id);
                if (target != null)
                {
                    target.Age = person.Age;
                    target.Name = person.Name;
                }
                else
                {
                    throw new GraphQLException(new Error("Person Not Found!", "404"));
                }
            }
            catch
            {
                throw new GraphQLException();
            }
           
        }
    }
}
