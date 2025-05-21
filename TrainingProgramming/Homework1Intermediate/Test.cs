namespace TrainingProgramming.Homework1Intermediate
{
    public class Test
    {
        [Test]
        public void TestMethod()
        {
            List<Person> persons = new List<Person>();
            persons.Add (new Person("Cristina", "Filipan", 35));
            persons.Add (new Person("Ioana", "Pop", 25));

            Console.WriteLine("The persons are:");
            foreach (Person person in persons)
            {
                Console.WriteLine($"First Name: {person.GetFirstName()}, Last Name: {person.GetLastName()}, Age: {person.GetAge()}");
            }
            Console.WriteLine();

            Console.WriteLine("The persons with age greater than 30 are: ");
            foreach (Person person in persons)
            {
                if (person.GetAge()>30)
                {
                    Console.WriteLine(person.GetFullName());
                }
            }

            Console.WriteLine();
            foreach (Person person in persons)
            {
                if (person.GetFullName() == "Ioana Pop")
                {
                   person.SetAge(person.GetAge()+1);
                   Console.WriteLine($"The current age of {person.GetFullName()} is {person.GetAge()}");
                   break;
                   
                }
                
            }


            Console.WriteLine();
            foreach (Person person in persons)
            {
                if (person.GetFirstName() == "Cristina" && person.GetAge()==35)
                {
                    string initialLastName=person.GetLastName();
                    person.SetLastName("Popescu");
                    Console.WriteLine($"{person.GetFirstName()} changed its last name from {initialLastName} to {person.GetLastName()}");
                    break;

                }

            }

            Console.WriteLine();
            foreach (Person person in persons)
            {
                if (person.GetLastName() == "Pop" && person.GetAge()==26)
                {
                    string initialFirstName = person.GetFirstName();
                    person.SetFirstName("Adriana");
                    Console.WriteLine($"{initialFirstName} changed its first name from {initialFirstName} to {person.GetFirstName()}");
                    break;

                }

            }


        }
    }
}

