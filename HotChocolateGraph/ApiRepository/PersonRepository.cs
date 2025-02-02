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
            _list.Add(person);
        }

        public List<Person> GetPeople()
        {
            return _list;
        }

        public void Update(Person person)
        {
            var target = _list.FirstOrDefault(x => x.Id == person.Id);
            if (target != null)
            {
                target.Age = person.Age;    
                target.Name = person.Name;
            }
        }
    }
}
