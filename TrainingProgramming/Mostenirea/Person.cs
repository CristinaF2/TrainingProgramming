namespace TrainingProgramming.Mostenirea
{
    public class Person
    {
        public string name;
        public int age;
        public double weight;

        public Person(string name, int age, double weight) 
        {
            this.name=name;
            this.age=age;
            this.weight=weight;
        }

        public void InfoPerson()
        {
            Console.WriteLine($"Nume persoana: {name}");
            Console.WriteLine($"Nume persoana: {age}");
            Console.WriteLine($"Nume persoana: {weight}");
        }

    }
}
