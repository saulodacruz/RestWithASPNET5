using RestWithASPNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new();
            for (int i = 0; i < 8; i++)
                persons.Add(MockPerson(i));
            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Saulo",
                LastName = "Cruz",
                Address = "Av Pres. Joao Goulart, 3 - Umuarama, 06036048, Osasco-SP, Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Saulo " + i,
                LastName = "Cruz " + i,
                Address = "Av Pres. Joao Goulart, 3 - Umuarama, 06036048, Osasco-SP, Brasil " + i,
                Gender = "Male " + i
            };
        }
    }
}
