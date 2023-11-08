namespace SecondProject
{
    public class Person
    {
        public Person()
        {

        }

        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Person {FirstName} {LastName} has {Age} years";
        }
    }
}
