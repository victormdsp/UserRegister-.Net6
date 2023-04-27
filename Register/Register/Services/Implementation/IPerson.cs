using Register.Model;

namespace Register.Services.Implementation
{
    public interface IPerson
    {
        Person Create(Person person);
        Person Update(Person person);
        bool Delete(string id);
        Person Get(string id);
        List<Person> GetAll();
    }
}
