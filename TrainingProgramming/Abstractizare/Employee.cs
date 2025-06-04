using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrainingProgramming.Abstractizare
{
    public class Employee : Person, IEmployee
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

        public void GoToWork()
        {
            Console.WriteLine($"Employee goes to work");
        }

        public void TakeABreak()
        {
            Console.WriteLine($"Employee takes a break");
        }

        public void AttendMeeting()
        {
            Console.WriteLine($"Employee attends a meeting");
        }
    }
}
