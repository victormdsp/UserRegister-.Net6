using Register.Model;
using Register.Services.Implementation;

namespace Register.Services
{
    public class PersonService : IPerson
    {
        public List<Person> persons = new List<Person>();

        public Person Create(Person person)
        {
            persons.Add(person);
            return person;
        }

        public Person Update(Person person)
        {
            int indexFoundedPerson = persons.FindIndex(personFromList => personFromList.Id == person.Id);
            if (indexFoundedPerson == -1) return null;
            persons[indexFoundedPerson] = person;
            return person;
        }

        public bool Delete(string id)
        {
            int indexFoundedPerson = persons.FindIndex(personFromList => personFromList.Id == id);
            if (indexFoundedPerson == -1) return false;
            persons.Remove(persons[indexFoundedPerson]);
            return true;
        }

        public Person Get(string id)
        {
            int indexFoundedPerson = persons.FindIndex(personFromList => personFromList.Id == id);
            if (indexFoundedPerson == -1) return null;
            return persons[indexFoundedPerson];
        }

        public List<Person> GetAll()
        {
            return persons;
        }
    }
}
