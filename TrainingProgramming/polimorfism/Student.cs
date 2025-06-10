namespace TrainingProgramming.polimorfism
{
    public class Student : Person
    {
        private string University { get; set; }

        private string Profile { get; set; }

        private bool HaveScholarship { get; set; }


        public Student(string nume, string prenume, int varsta, string universitate, string profil, bool areBursa) : base(nume, prenume, varsta)
        {
            University= universitate;
            Profile= profil;
            HaveScholarship= areBursa;
        }

        public void DisplayInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Universitate: {University}, Profil: {Profile}, Are bursa: {HaveScholarship}");
        }

        public override void Mananca()
        {
            Console.WriteLine("Student mananca.");
        }

    }
}
