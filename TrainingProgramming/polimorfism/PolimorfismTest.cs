namespace TrainingProgramming.polimorfism
{
    public class PolimorfismTest
    {
        [Test]
        public void TestMethod()
        {
            Student student = new Student("Ion", "Popescu", 20, "Universitatea Bucuresti", "Informatica", true);
            student.Mananca();

            Person person = new Person("Maria", "Ionescu", 30);
            person.Mananca();


        }
        //polimorfism static
        //overloading
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(double a, double b)
        {
            return (int)(a + b);
        }

        //polimorfism dinamic



    }
}
