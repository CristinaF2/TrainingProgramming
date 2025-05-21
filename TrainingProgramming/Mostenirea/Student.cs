namespace TrainingProgramming.Mostenirea
{
    public class Student : Person
    {
        public string university;
        public string profile;
        public bool hasScholarship;
        public Student(string name, int age, double weight, string university, string profile, bool hasScholarship
            ) : base(name, age, weight)
        {

            this.university = university;
            this.profile = profile;
            this.hasScholarship = hasScholarship;
        }

        public void InfoStudent()
        {
            InfoPerson();
            Console.WriteLine($"Universitatea studentului este: {university}");
            Console.WriteLine($"Profilul studentului este: {profile}");
            Console.WriteLine($"Stuentul are bursa: {hasScholarship}");



        }
    }
}
