namespace TrainingProgramming.Abstractizare.AbstractizarePrinInterfete
{
    public class Student : Person, IStudent
    {
        private string University { get; set; }

        private string Profile { get; set; }

        private bool HaveScholarship { get; set; }
         

        public Student(string nume, string prenume, int varsta, string universitate, string profil, bool areBursa ) : base(nume, prenume, varsta)
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

        public void Study()
        {
            Console.WriteLine($"Student is studying");   
        }

        public void TakeExam()
        {
            Console.WriteLine($"Student is taking an exam");

        }

        public void AttendClass()
        {
            Console.WriteLine($"Student is attending a class");

        }
    }
}
