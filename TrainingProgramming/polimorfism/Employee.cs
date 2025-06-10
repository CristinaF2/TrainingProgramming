namespace TrainingProgramming.polimorfism
{
    public class Employee : Person
    {
        public double Salary { get; set; }
        public string Company { get; set; }


        public Employee(string nume, string prenume, int varsta, string company, double salary) : base(nume, prenume, varsta)
        {
            Salary= salary;
            Company= company;

        }

        public void DisplayInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Salary: {Salary}, Company: {Company}");

        }
    }
}
