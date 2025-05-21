namespace TrainingProgramming.Homework1Intermediate
{
    public class Person
    {
        private string firstName;
        private string lastName;
        protected int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public string GetFirstName()
        {
            return firstName;
        }   

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }   

        public string GetFullName()
        {
            string fullName= firstName + " " + lastName;
            return fullName;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }   


    }
}
