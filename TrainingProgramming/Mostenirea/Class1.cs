namespace TrainingProgramming.Mostenirea
{
    public class Class1
    {
        //concept prin care o clasa(copil) mosteneste alta clasa (parinte)
        //in c# nu se poate mosteni decat o clasa(ca si in java)
        //clasa copil preia atributele si metodele  clasei parinte
        //
        [Test]
        public void Test()
        {
            //Person person;
            var person = new Person("Mihai",30,105.5);
            person.InfoPerson();
            Console.WriteLine();

            var ion = new Angajat("IOnel POpescu", 35, 100, "tester", 1000, "NTTData");
            ion.InfoAngajat();
            Console.WriteLine();

            var Ana = new Student("Ana MAria Popa", 21, 50, "UTCN", "ETTI", true);
            Ana.InfoStudent();
            Console.WriteLine();
        }
    }
}
