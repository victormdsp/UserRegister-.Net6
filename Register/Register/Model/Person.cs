namespace Register.Model
{
    public class Person
    {
        public string Id {set; get;}
        public string FirstName { set; get;}
        public string LastName { set; get;}
        public string Email { set; get;}
        public char Gender { set; get;}

        public Person(string id, string firstName, string lastName, string email, char gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
        }
    }
}
