namespace TrainingProgramming.Mostenirea
{
    public class Angajat : Person
    {
        public string job;
        public double salary;
        public string employer;

        public Angajat(string name, int age, double weight, string job, double salary, string employer) : base(name, age, weight)
        {
            this.job=job;
            this.salary=salary;
            this.employer=employer;
        }

        public void InfoAngajat()
        {
            InfoPerson();
            Console.WriteLine($"Jobul angajatului este: {job}");
            Console.WriteLine($"Salariul angajatului este: {salary}");
            Console.WriteLine($"Angajatorul angajatului este: {employer}");


        }
    }
}
